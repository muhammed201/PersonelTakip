using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PersonelTakip
{
    internal class genel
    {
        //enterUserName ve enterUserAuthority ile sisteme giren kullanıcının ve yetkisini genel bir değişken olarak kayıt ediyoruz. 
        public static string enterUserName;
        public static string enterUserAuthority;
        public static bool acikFormKontrolEt(string name)
        {
            FormCollection fc = Application.OpenForms;
            foreach (Form frm in fc)
            {
                //MessageBox.Show(frm.Name.ToString());                
                if (frm.Name == name)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
