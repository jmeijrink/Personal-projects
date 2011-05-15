using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MissileControl
{
   /// <summary>
   /// TODO: make form respond correctly to removed and added devices.
   /// TODO: Disable buttons when performing action cause by that button.
   /// </summary>
   public partial class Form1 : Form
   {
      
      public Form1()
      {
         InitializeComponent();
      }

      private void Form1_Load(object sender, EventArgs e)
      {
         USBDrivers.MissileLauncher[] mls = USBDrivers.MissileLauncher.FindMissileLaunchers();
         foreach (USBDrivers.MissileLauncher ml in mls)
         {
            lstDevices.Items.Add(ml);
            lstDevices.SelectedIndices.Add(lstDevices.Items.Count - 1);
//            ml.OnDeviceRemoved += new EventHandler(ml_OnDeviceRemoved);
         }


      }

      private void ActOnSelectedDevices(string function)
      {
         Type ml = typeof(USBDrivers.MissileLauncher);
         System.Reflection.MethodInfo method = ml.GetMethod(function);
         foreach (object o in lstDevices.SelectedItems)
         {
            method.Invoke(o, new object[] { });
         }
      }

      private void btnLeft_Click(object sender, EventArgs e)
      {
         ActOnSelectedDevices("BeginTurningLeft");
      }

      private void btnRight_Click(object sender, EventArgs e)
      {
         ActOnSelectedDevices("BeginTurningRight");
      }

      private void btnStop_Click(object sender, EventArgs e)
      {
         ActOnSelectedDevices("StopTurning");
      }

      private void btnUpLeft_Click(object sender, EventArgs e)
      {
         ActOnSelectedDevices("BeginTurningLeft");
         ActOnSelectedDevices("BeginTurningUp");
      }

      private void btnDown_Click(object sender, EventArgs e)
      {
         ActOnSelectedDevices("BeginTurningDown");
      }

      private void btnFire_Click(object sender, EventArgs e)
      {
         ActOnSelectedDevices("Fire");
      }

      private void btnTurnUp_Click(object sender, EventArgs e)
      {
         ActOnSelectedDevices("BeginTurningUp");
      }

      private void btnUpRight_Click(object sender, EventArgs e)
      {
         ActOnSelectedDevices("BeginTurningUp");
         ActOnSelectedDevices("BeginTurningRight");
      }

      private void btnDownRight_Click(object sender, EventArgs e)
      {
         ActOnSelectedDevices("BeginTurningDown");
         ActOnSelectedDevices("BeginTurningRight");
      }

      private void btnDownLeft_Click(object sender, EventArgs e)
      {
         ActOnSelectedDevices("BeginTurningDown");
         ActOnSelectedDevices("BeginTurningLeft");
      }

      private void btnPrime_Click(object sender, EventArgs e)
      {
         ActOnSelectedDevices("BeginPriming");
      }
   }
}