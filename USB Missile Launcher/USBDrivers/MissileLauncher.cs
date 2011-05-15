using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace USBDrivers
{
   public class MissileLauncher : HIDDevice
   {
      private bool _turningLeft = false;
      private bool _turningRight = false;
      private bool _turningUp = false;
      private bool _turningDown = false;
      private bool _slow = false;
      private bool _firing = false;
      private bool _priming = false;

      private bool _fireOnce = false;

      private List<System.Timers.Timer> _timers = new List<System.Timers.Timer>();

      public event EventHandler StoppedTurningLeft;
      public event EventHandler StoppedTurningRight;
      public event EventHandler StoppedTurningUp;
      public event EventHandler StoppedTurningDown;
      public event EventHandler MissileFired;
      public event EventHandler PrimingReady;

      #region Turn by duration
      /// <summary>
      /// Turns the launcher to the left.
      /// </summary>
      /// <param name="duration">Time in milliseconds</param>
      public void TurnLeft(int duration)
      {
         BeginTurningLeft();
         System.Timers.Timer tmr = new System.Timers.Timer();
         tmr.Interval = duration;
         tmr.Elapsed += new System.Timers.ElapsedEventHandler(tmrTurnLeft_Elapsed);
         tmr.Enabled = true;
         _timers.Add(tmr);
      }

      private void tmrTurnLeft_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
      {
         System.Timers.Timer tmr = (System.Timers.Timer)sender;
         tmr.Enabled = false;
         _timers.Remove(tmr);
         StopTurningLeft();
      }

      /// <summary>
      /// Turns the launcher to the right.
      /// </summary>
      /// <param name="duration">Time in seconds</param>
      public void TurnRight(int duration)
      {
         BeginTurningRight();
         _turningRight = true;
         Thread.Sleep(2000);
         StopTurningRight();
      }

      /// <summary>
      /// Turns the launcher upwards.
      /// </summary>
      /// <param name="duration">Time in seconds</param>
      public void TurnUp(int duration)
      {
         throw new System.NotImplementedException();
      }

      /// <summary>
      /// Turns the launcher upwards.
      /// </summary>
      /// <param name="duration">Time in seconds</param>
      public void TurnDown(int duration)
      {
         throw new System.NotImplementedException();
      }
      #endregion

      #region ASync turn operations
      /// <summary>
      /// Starts turning the launcher to the left.
      /// </summary>
      /// <returns>True if turning left started, false otherwise</returns>
      public bool BeginTurningLeft()
      {
         //generate output report.
         MissileLauncherOutputReport mlor = MissileLauncherOutputReport.createReport(this);
         mlor.AddTurnLeft();
         mlor.RemoveTurnRight();
         _turningLeft = true;
         _turningRight = false;
         return Write(mlor);
      }

      /// <summary>
      /// Starts turning the launcher to the right.
      /// </summary>
      public bool BeginTurningRight()
      {
         MissileLauncherOutputReport mlor = MissileLauncherOutputReport.createReport(this);
         mlor.AddTurnRight();
         mlor.RemoveTurnLeft();
         _turningRight = true;
         _turningLeft = false;
         return Write(mlor);
      }

      /// <summary>
      /// Starts turning the launcher up.
      /// </summary>
      public bool BeginTurningUp()
      {
         MissileLauncherOutputReport mlor = MissileLauncherOutputReport.createReport(this);
         mlor.AddTurnUp();
         mlor.RemoveTurnDown();
         _turningUp = true;
         _turningDown = false;
         return Write(mlor);
      }

      /// <summary>
      /// Starts turning the launcher down.
      /// </summary>
      public bool BeginTurningDown()
      {
         MissileLauncherOutputReport mlor = MissileLauncherOutputReport.createReport(this);
         mlor.AddTurnDown();
         mlor.RemoveTurnUp();
         _turningDown = true;
         _turningUp = false;
         return Write(mlor);
      }

      /// <summary>
      /// Stops turning the launcher.
      /// </summary>
      public void StopTurning()
      {
         this.StopTurningDown();
         this.StopTurningUp();
         this.StopTurningRight();
         this.StopTurningLeft();
      }

      /// <summary>
      /// Stops turning the launcher to the left.
      /// </summary>
      public void StopTurningLeft()
      {
         //Left is set for slow speed, do not undo that.
         if ((TurningUp || TurningDown) && _slow) return;

         if (_turningLeft)
         {
            MissileLauncherOutputReport mlor = MissileLauncherOutputReport.createReport(this);
            mlor.RemoveTurnLeft();
            _turningLeft = false;
            Write(mlor);
            if (StoppedTurningLeft != null) StoppedTurningLeft(this, new EventArgs());
         }
      }

      /// <summary>
      /// Stops turning the launcher to the right.
      /// </summary>
      public void StopTurningRight()
      {
         //Right is set for slow speed, do not undo that.
         if ((TurningUp || TurningDown) && _slow) return;

         if (_turningRight)
         {
            MissileLauncherOutputReport mlor = MissileLauncherOutputReport.createReport(this);
            mlor.RemoveTurnRight();
            _turningRight = false;
            Write(mlor);
            if (StoppedTurningRight != null) StoppedTurningRight(this, new EventArgs());
         }
      }

      /// <summary>
      /// Stops turning the launcher upwards.
      /// </summary>
      public void StopTurningUp()
      {
         //Up is set for slow speed, do not undo that.
         if ((TurningLeft || TurningRight) && _slow) return;

         if (_turningUp)
         {
            MissileLauncherOutputReport mlor = MissileLauncherOutputReport.createReport(this);
            mlor.RemoveTurnUp();
            _turningUp = false;
            Write(mlor);
            if (StoppedTurningUp != null) StoppedTurningUp(this, new EventArgs());
         }
      }

      /// <summary>
      /// Stops turning the launcher downwards.
      /// </summary>
      public void StopTurningDown()
      {
         //Down is set for slow speed, do not undo that.
         if ((TurningLeft || TurningRight) && _slow) return;

         if (_turningDown)
         {
            MissileLauncherOutputReport mlor = MissileLauncherOutputReport.createReport(this);
            mlor.RemoveTurnDown();
            _turningDown = false;
            Write(mlor);
            if (StoppedTurningDown != null) StoppedTurningDown(this, new EventArgs());
         }
      }
      #endregion

      #region Firing and priming
      public void BeginPriming()
      {
         //priming and firing is the same command, 
         //the callback event is different.
         MissileLauncherOutputReport mlor = MissileLauncherOutputReport.createReport(this);
         mlor.AddFire();
         Write(mlor);
         _priming = true;
         _firing = false;
      }

      public void Fire()
      {
         _fireOnce = true;
         BeginFiring();
      }

      public void BeginFiring()
      {
         MissileLauncherOutputReport mlor = MissileLauncherOutputReport.createReport(this);
         mlor.AddFire();
         Write(mlor);
         _firing = true;
         _priming = false;
      }

      public void CancelFiring()
      {
         //The message is received multiple times, only process it the first time.
         //Priming variable doesn't need to get updated.
         if (_firing)
         {
            MissileLauncherOutputReport mlor = MissileLauncherOutputReport.createReport(this);
            mlor.RemoveFire();
            Write(mlor);
            _fireOnce = false;
            _firing = false;
         }
      }

      public void CancelPriming()
      {
         //The message is received multiple times, only process it the first time.
         //Priming variable doesn't need to get updated.
         if (_priming)
         {
            MissileLauncherOutputReport mlor = MissileLauncherOutputReport.createReport(this);
            mlor.RemoveFire();
            Write(mlor);
            _priming = false;
         }
      }
      #endregion

      #region Status properties
      public bool TurningLeft { get { return _turningLeft; } }
      public bool TurningRight { get { return _turningRight; } }
      public bool TurningUp { get { return _turningUp; } }
      public bool TurningDown { get { return _turningDown; } }
      public bool Slow { get { return _slow; } }
      public bool Priming { get { return _priming; } }
      public bool Firing { get { return _firing; } }

      internal bool FireOnce { get { return _fireOnce; } }
      #endregion

      #region input report event handlers
      internal void cb_LeftEndReached(object sender, EventArgs e)
      {
         this.StopTurningLeft();
      }

      internal void cb_RightEndReached(object sender, EventArgs e)
      {
         this.StopTurningRight();
      }

      internal void cb_TopReached(object sender, EventArgs e)
      {
         this.StopTurningUp();
      }

      internal void cb_BottomReached(object sender, EventArgs e)
      {
         this.StopTurningDown();
      }

      internal void cb_MissileFired(object sender, EventArgs e)
      {
         if (this.FireOnce)
         {
            this.CancelFiring();
         }
      }

      private void cb_PrimingComplete(object sender, EventArgs e)
      {
         if (this.Priming)
         {
            this.CancelPriming();
         }
      }
      #endregion

      public override string ToString()
      {
         return "Dream Cheeky - USB Missile Launcher";
      }

      public static MissileLauncher[] FindMissileLaunchers()
      {
         return Array.ConvertAll<HIDDevice, MissileLauncher>(FindDevices(0x1941, 0x8021, typeof(MissileLauncher)), HIDDeviceToMissileLauncher); 
      }

      private static MissileLauncher HIDDeviceToMissileLauncher(HIDDevice device)
      {
         return (MissileLauncher)device;
      }

      private bool Write(MissileLauncherOutputReport mlor)
      {
         try
         {
            base.Write(mlor); // write the output report
         }
         catch (HIDDeviceException ex)
         {
            // Device may have been removed!
            return false;
         }
         return true;
      }

      public override InputReport CreateInputReport()
      {
         MissileLauncherInputReport mlir = new MissileLauncherInputReport(this);

         mlir.LeftEndReached += new EventHandler(this.cb_LeftEndReached);
         mlir.RightEndReached += new EventHandler(this.cb_RightEndReached);
         mlir.TopReached += new EventHandler(this.cb_TopReached);
         mlir.BottomReached += new EventHandler(this.cb_BottomReached);
         mlir.MissileFired += new EventHandler(this.cb_MissileFired);
         mlir.PrimingComplete += new EventHandler(this.cb_PrimingComplete);
         return mlir;
      }
   }

   public class DataEventArgs : EventArgs
   {
      public readonly byte[] Data;

      internal DataEventArgs(byte[] buffer)
      {
         Data = buffer;
      }
   }

   /// <summary>
   /// Class that performs byte array operations to complete goal.
   /// All Commands
   /// Stop            0000 0000  00
   /// Up              0000 0001  01
   /// Down            0000 0010  02
   /// Left            0000 0100  04
   /// Up Left         0000 0101  05
   /// Down Left       0000 0110  06
   /// Slow Left       0000 0111  07
   /// Right           0000 1000  08
   /// Up Right        0000 1001  09
   /// Down Right      0000 1010  0A
   /// Slow Right      0000 1011  0B
   /// Slow Up         0000 1101  0D
   /// Slow Down       0000 1110  0E
   /// Fire            0001 0000  10
   /// Fire Left       0001 0100  14
   /// Fire Right      0001 1000  18
   /// Fire Up Left    0001 0101  15
   /// Fire Up Right   0001 1001  19
   /// Fire Down Right 0001 1010  1A
   ///
   /// Commands by byte:
   /// Up              0000 0001
   /// Down            0000 0010
   /// Left            0000 0100
   /// Right           0000 1000
   /// Fire            0001 0000
   /// These commands can be combined in any way you want. Except for Up, Down or 
   /// Left and Right at the same time.
   /// Left, Right and one vertical value means slow vertical
   /// Up, Down and one horizontal value means slow horizontal
   /// 
   /// Request                    0000009
   /// Request type    0010 0001  21
   /// Request value              0000200
   /// </summary>
   internal class MissileLauncherOutputReport : OutputReport
   {
      MissileLauncher _ml = null;

      /// <summary>
      /// Constructor
      /// </summary>
      /// <param name="oDev">Device constructing this report</param>
      private MissileLauncherOutputReport(HIDDevice oDev)
         : base(oDev)
      {
         //Initialize command byte array.
         _ml = (MissileLauncher)oDev;
      }

      private void SetStatus(
         bool turningLeft,
         bool turningRight,
         bool turningUp,
         bool turningDown,
         bool slow,
         bool firing)
      {
         if (turningLeft && turningRight) turningLeft = turningRight = false;
         if (turningUp && turningDown) turningUp = turningDown = false;

         if (turningLeft) AddTurnLeft();
         if (turningRight) AddTurnRight();
         if (turningUp) AddTurnUp();
         if (turningDown) AddTurnDown();
         if (slow)
         {  //Make sure slow is not set when moving diagonally
            if (turningDown || turningUp && !(turningLeft || turningRight))
            {
               AddSlowVertical();
            }
            else if (turningLeft || turningRight && !(turningUp || turningDown))
            {
               AddSlowHorizontal();
            }
         }

         if (firing) AddFire();
      }

      public void AddTurnUp()
      {
         Buffer[1] |= 0x01;
      }

      public void AddTurnDown()
      {
         Buffer[1] |= 0x02;
      }

      public void AddTurnLeft()
      {
         Buffer[1] |= 0x04;
      }

      public void AddTurnRight()
      {
         Buffer[1] |= 0x08;
      }

      public void AddSlowHorizontal()
      {
         Buffer[1] |= 0x03;
      }

      public void AddSlowVertical()
      {
         Buffer[1] |= 0x0C;
      }

      public void AddFire()
      {
         Buffer[1] |= 0x10;
      }

      public void RemoveFire()
      {
         Buffer[1] &= 0xEF;
      }

      public void RemoveTurnUp()
      {
         Buffer[1] &= 0xFE;
      }

      public void RemoveTurnDown()
      {
         Buffer[1] &= 0xFD;
      }

      public void RemoveTurnLeft()
      {
         Buffer[1] &= 0xFB;
      }

      public void RemoveTurnRight()
      {
         Buffer[1] &= 0xF7;
      }

      public void RemoveSlowVertical()
      {
         Buffer[1] &= 0xF3;
      }

      public void RemoveSlowHorizontal()
      {
         Buffer[1] &= 0xFC;
      }

      public static MissileLauncherOutputReport createReport(MissileLauncher ml)
      {
         MissileLauncherOutputReport mlor = new MissileLauncherOutputReport(ml);
         mlor.SetStatus(ml.TurningLeft, ml.TurningRight, ml.TurningUp, ml.TurningDown, ml.Slow, ml.Firing);
         return mlor;
      }
   }

   internal class MissileLauncherInputReport : InputReport
   {
      private static byte[] _prevBuffer = null;

      public event EventHandler LeftEndReached;
      public event EventHandler RightEndReached;
      public event EventHandler TopReached;
      public event EventHandler BottomReached;
      public event EventHandler MissileFired;
      public event EventHandler PrimingComplete;

      /// <summary>
      /// Constructor
      /// </summary>
      /// <param name="oDev">Constructing device</param>
      public MissileLauncherInputReport(HIDDevice oDev)
         : base(oDev)
      { }

      public override void ProcessData()
      {
         //bottom reached buffer[1] == 64
         //top reached buffer[1] == 128
         //left reached buffer[2] == 4
         //right reached buffer[2] == 8
         //priming ready [2] == 128
         //bool different = false;
         if (_prevBuffer == null) _prevBuffer = base.Buffer;

         //by performing an x-or operation on the
         //previous buffer with 1, the buffer gets inverted.
         //if this buffer is then binary-anded with the current
         //buffer only the changes will come throug.
         byte[] changes = new byte[base.BufferLength];
         for (int i = 0; i < base.BufferLength; i++)
         {
            changes[i] = (byte)((_prevBuffer[i] ^ 1) & base.Buffer[i]);
         }

         if ((changes[1] & 0x40) == 0x40) BottomReached(this, new EventArgs());
         if ((changes[1] & 0x80) == 0x80) TopReached(this, new EventArgs());
         if ((changes[2] & 0x04) == 0x04) LeftEndReached(this, new EventArgs());
         if ((changes[2] & 0x08) == 0x08) RightEndReached(this, new EventArgs());
         if ((changes[2] & 0x80) == 0x80) PrimingComplete(this, new EventArgs());

         //Stop firing after priming is complete, not 
         //as the first message is received.
         string received = String.Empty;
         for (int i = 0; i < base.Buffer.Length; i++)
         {
            received += base.Buffer[i].ToString() + " ";
         }
         System.Diagnostics.Debug.Print("Buffer received: " + received);
         if ((_prevBuffer[2] & 0x80) == 0x80 &&
             (base.Buffer[2] & 0x80) == 0x00)
         {
            MissileFired(this, new EventArgs());
         }

         _prevBuffer = base.Buffer;
      }
   }
}
