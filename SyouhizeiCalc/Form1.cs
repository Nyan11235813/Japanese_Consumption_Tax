using System;
using System.Windows.Forms;

namespace SyouhizeiCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalcButton_Click(object sender, EventArgs e)
        {
            // �󗓂Ȃ�0��ݒ�
            if (string.IsNullOrWhiteSpace(zeinuki.Text))
            {
                zeinuki.Text = "0";
            }

            // �Ŕ����z�̎擾�i�����ȊO�����͂��ꂽ�ꍇ�̃G���[�n���h�����O�j
            if (decimal.TryParse(zeinuki.Text, out decimal taxExcluded))
            {
                // �ŗ��̎擾�i8% or 10%�j
                decimal taxRate = zeiritu.SelectedItem.ToString() == "8%" ? 0.08m : 0.10m;

                // ����ł̌v�Z
                decimal taxAmount = taxExcluded * taxRate;

                // �[�������̓K�p
                switch (hasuu.SelectedItem.ToString())
                {
                    case "�؂�̂�":
                        taxAmount = Math.Floor(taxAmount);
                        break;
                    case "�؂�グ":
                        taxAmount = Math.Ceiling(taxAmount);
                        break;
                    case "�l�̌ܓ�":
                        taxAmount = Math.Round(taxAmount, MidpointRounding.AwayFromZero);
                        break;
                }

                // ���ʂ̕\��
                syouhizei.Text = taxAmount.ToString();
                zeikomi.Text = (taxExcluded + taxAmount).ToString();
            }
            else
            {
                MessageBox.Show("���͂̒l�Ɍ�肪����܂�", "�G���[");
                zeinuki.Focus(); // �G���[�������Ƀt�H�[�J�X��߂�
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            // ���͂ƌ��ʂ��N���A
            zeinuki.Text = "";
            syouhizei.Text = "";
            zeikomi.Text = "";

            // �����t�H�[�J�X��Ŕ����z���֖͂߂�
            zeinuki.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // �����ݒ�
            zeiritu.SelectedIndex = 0; // 8%���f�t�H���g�I��
            hasuu.SelectedIndex = 0; // �؂�̂Ă��f�t�H���g�I��
        }
    }
}