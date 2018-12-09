using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraBars;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.XtraSplashScreen;
using DevExpress.XtraTab;
using DevExpress.Utils;


namespace ProjectRunningFox
{
    class Tutorial
    {
        public void TutorialPart2(Form1 f)
        {
            f.labelControl23.Visible = false;
            f.pictureBox44.Visible = false;
            f.pictureBox44.BringToFront();
            f.BETA_Part1.Enabled = false;
            f.pictureBox45.Visible = true;
            f.labelControl400.Visible = true;
            f.labelControl422.Visible = true;
            f.labelControl422.BringToFront();
            f.xtraTabPage12.PageEnabled = false;
            f.xtraTabPage22.PageEnabled = false;
            f.xtraTabPage21.PageEnabled = false;
            f.simpleButton26.Enabled = false;
        }
        public void TutorialPart1(Form1 f)
        {
            f.Text = "Project Running Fox [BETA] Tutorial Mode";
            f.tileItem2.Enabled = false;
            f.tileItem3.Enabled = false;
            f.tileItem4.Enabled = false;
            f.tileItem5.Enabled = false;
            f.tileItem6.Enabled = false;
            f.tileItem7.Enabled = false;
            f.tileItem8.Enabled = false;
            f.tileItem9.Enabled = false;
            f.tileItem10.Enabled = false;
            f.tileItem11.Enabled = false;
            f.tileItem12.Enabled = false;
            f.tileItem13.Enabled = false;
            f.tileItem14.Enabled = false;
            f.tileItem15.Enabled = false;
            f.tileItem16.Enabled = false;
            f.tileItem17.Enabled = false;
            f.tileItem18.Enabled = false;
            f.tileItem19.Enabled = false;
            f.tileItem20.Enabled = false;
            f.tileItem21.Enabled = false;
            f.tileItem22.Enabled = false;
            f.tileItem23.Enabled = false;
            f.tileItem24.Enabled = false;
            f.tileItem25.Enabled = false;
            f.tileItem26.Enabled = false;
            f.tileItem27.Enabled = false;
            f.tileItem28.Enabled = false;
            f.tileItem29.Enabled = false;
            f.tileItem30.Enabled = false;
            f.tileItem31.Enabled = false;
            f.tileItem32.Enabled = false;
            f.tileItem33.Enabled = false;
            f.tileItem37.Enabled = false;
            f.tileItem38.Enabled = false;
            f.tileItem39.Enabled = false;
            f.labelControl23.Visible = true;
            f.pictureBox44.Visible = true;
            f.pictureBox44.BringToFront();
            f.BETA_Part1.Enabled = true;
        }
    }
}
