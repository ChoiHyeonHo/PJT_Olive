using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PJT_Olive
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region 패널 속성 초기값
            pnlMain1.Height = pnlMain2.Height = pnlMain3.Height = pnlMain4.Height = pnlMain5.Height = pnlMain6.Height = 50;
            pnlSub1.Visible = pnlSub2.Visible = pnlSub3.Visible = pnlSub4.Visible = pnlSub5.Visible = pnlSub6.Visible = false;
            #endregion
        }

        private void btnEntering_Click(object sender, EventArgs e)
        {
            #region 입고관리 버튼
            pnlMain2.Height = 110;
            if (pnlSub2.Visible)
                pnlSub2.Visible = false;
            else
                pnlSub2.Visible = true;
            if (!pnlSub2.Visible)
                pnlMain2.Height = 50;
            else
                pnlMain2.Height = 110;
            #endregion
        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
            #region 출고관리 버튼
            pnlMain3.Height = 110;
            if (pnlSub3.Visible)
                pnlSub3.Visible = false;
            else
                pnlSub3.Visible = true;
            if (!pnlSub3.Visible)
                pnlMain3.Height = 50;
            else
                pnlMain3.Height = 110;
            #endregion
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            #region 제품관리 버튼
            pnlMain1.Height = 110;
            if (pnlSub1.Visible)
                pnlSub1.Visible = false;
            else
                pnlSub1.Visible = true;
            if (!pnlSub1.Visible)
                pnlMain1.Height = 50;
            else
                pnlMain1.Height = 110;
            #endregion
        }

        private void btnMaterails_Click(object sender, EventArgs e)
        {
            #region 재고관리 버튼
            pnlMain4.Height = 110;
            if (pnlSub4.Visible)
                pnlSub4.Visible = false;
            else
                pnlSub4.Visible = true;
            if (!pnlSub4.Visible)
                pnlMain4.Height = 50;
            else
                pnlMain4.Height = 110;
            #endregion
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            #region 거래처관리 버튼
            pnlMain5.Height = 110;
            if (pnlSub5.Visible)
                pnlSub5.Visible = false;
            else
                pnlSub5.Visible = true;
            if (!pnlSub5.Visible)
                pnlMain5.Height = 50;
            else
                pnlMain5.Height = 110;
            #endregion
        }

        private void btnBOM_Click(object sender, EventArgs e)
        {
            #region BOM관리 버튼
            pnlMain6.Height = 110;
            if (pnlSub6.Visible)
                pnlSub6.Visible = false;
            else
                pnlSub6.Visible = true;
            if (!pnlSub6.Visible)
                pnlMain6.Height = 50;
            else
                pnlMain6.Height = 110;
            #endregion
        }
    }
}
