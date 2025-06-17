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
            // 空欄なら0を設定
            if (string.IsNullOrWhiteSpace(zeinuki.Text))
            {
                zeinuki.Text = "0";
            }

            // 税抜金額の取得（数字以外が入力された場合のエラーハンドリング）
            if (decimal.TryParse(zeinuki.Text, out decimal taxExcluded))
            {
                // 税率の取得（8% or 10%）
                decimal taxRate = zeiritu.SelectedItem.ToString() == "8%" ? 0.08m : 0.10m;

                // 消費税の計算
                decimal taxAmount = taxExcluded * taxRate;

                // 端数処理の適用
                switch (hasuu.SelectedItem.ToString())
                {
                    case "切り捨て":
                        taxAmount = Math.Floor(taxAmount);
                        break;
                    case "切り上げ":
                        taxAmount = Math.Ceiling(taxAmount);
                        break;
                    case "四捨五入":
                        taxAmount = Math.Round(taxAmount, MidpointRounding.AwayFromZero);
                        break;
                }

                // 結果の表示
                syouhizei.Text = taxAmount.ToString();
                zeikomi.Text = (taxExcluded + taxAmount).ToString();
            }
            else
            {
                MessageBox.Show("入力の値に誤りがあります", "エラー");
                zeinuki.Focus(); // エラー発生時にフォーカスを戻す
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            // 入力と結果をクリア
            zeinuki.Text = "";
            syouhizei.Text = "";
            zeikomi.Text = "";

            // 初期フォーカスを税抜金額入力へ戻す
            zeinuki.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 初期設定
            zeiritu.SelectedIndex = 0; // 8%をデフォルト選択
            hasuu.SelectedIndex = 0; // 切り捨てをデフォルト選択
        }
    }
}