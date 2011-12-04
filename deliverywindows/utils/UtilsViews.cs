using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace deliverywindows.utils
{
    class UtilsViews
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="mensaje"></param>
        /// <param name="title"></param>
        public static void showMsgError(String mensaje,String title = "") {
            MessageBox.Show(mensaje,title,MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="mensaje"></param>
        /// <param name="title"></param>
        public static void showMsgAlert(String mensaje,String title = "") {
            MessageBox.Show(mensaje,title,MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="mensaje"></param>
        /// <param name="title"></param>
        /// <returns></returns>
        public static DialogResult showMsgConfirm(String mensaje, String title = "") {
            return MessageBox.Show(mensaje, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public static void showMsgSuccess(String mensaje, String title = "") {
            MessageBox.Show(mensaje, title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

    }
}
