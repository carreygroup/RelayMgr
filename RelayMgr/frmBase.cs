using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RelayMgr
{
    public partial class frmBase : Form
    {
        public frmBase()
        {
            InitializeComponent();
        }

        private void frmBase_Load(object sender, EventArgs e)
        {
            if (Localization.HasLang)
                RefreshLanguage(this);
        }
        // 更新窗体语言
        public static void RefreshLanguage(Form form)
        {
            form.Text = Localization.Forms[form.Name][form.Name];
            SetControlsLanguage(form, Localization.Forms[form.Name]);
        }

        /// <summary>
        /// 设置control子控件语言
        /// </summary>
        /// <param name="control">父控件</param>
        /// <param name="obj">语言字典</param>
        public static void SetControlsLanguage(Control control, Dictionary<string, string> obj)
        {
            foreach (Control ctrl in control.Controls)
            {
                // set the control which one's key in the dictionary
                string text = "";
                if (obj.TryGetValue(ctrl.Name, out text))
                    ctrl.Text = text;

                if (ctrl.HasChildren)
                    SetControlsLanguage(ctrl, obj);
            }
        }
    }
}
