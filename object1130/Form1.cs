using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace object1130
{
	public partial class Form1 : Form
	{

		/** 人の名前*/
		private string[] HITO_NAMES = { "佐藤", "鈴木", "高橋" };
		/** 鳥の名前*/
		private string[] TORI_NAMES = { "スズメ", "カラス", "ハト", "トビ" };
		/** 魚の名前*/
		private string[] SAKANA_NAMES = { "グッピー", "メダカ" };

		private CHito[] hitoObjects;


		/** 生き物の種類*/
		private enum IKIMONO_TYPE
		{
			IKIMONO_HITO,
			IKIMONO_TORI,
			IKIMONO_SAKANA
		}
		/** 自分の種類*/
		private IKIMONO_TYPE[] types;

		/** 名前*/
		private string[] names;

		/** 人の数*/
		private int iHitoCount;
		/** 鳥の数*/
		private int iToriCount;
		/** 魚の数*/
		private int iSakanaCount;
		/** 生き物の数*/
		private int iIkimonoCount;

		public Form1()
		{
			InitializeComponent();

			//CHito hito = new CHito("デジタルアーツ");
			//MessageBox.Show(hito.hello());
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			hitoObjects = new CHito[HITO_NAMES.Length];
			for (int i = 0; i < HITO_NAMES.Length; i++)
			{
				hitoObjects[i] = new CHito(HITO_NAMES[i]);
				textBox1.AppendText("" + i + ":" + HITO_NAMES[i] + "\r\n");
			}

		}

		private void buttonHello_Click(object sender, EventArgs e)
		{
			// 選択されているインデックスを取得
			int index = int.Parse(txtIndex.Text);

			// 挨拶
			textBox1.AppendText(hitoObjects[index].hello()+"\r\n");
		}

		private void buttonAction_Click(object sender, EventArgs e)
		{
			// 選択されているインデックスを取得
			int index = int.Parse(txtIndex.Text);

			// 行動
			textBox1.AppendText(hitoObjects[index].action()+"\r\n");
		}

		private void buttonNumber_Click(object sender, EventArgs e)
		{
			textBox1.AppendText("人は" + hitoObjects[0].getCount() + "人\r\n");
			textBox1.AppendText("鳥は" + iToriCount + "羽\r\n");
			textBox1.AppendText("魚は" + iSakanaCount + "匹\r\n");
			textBox1.AppendText("生き物は" + iIkimonoCount + "体。\r\n");
		}

		private void Form1_Load_1(object sender, EventArgs e)
		{
			Form1_Load(sender, e);
		}

		private void buttonAction_Click_1(object sender, EventArgs e)
		{
			buttonAction_Click(sender, e);
		}

		private void buttonNumber_Click_1(object sender, EventArgs e)
		{
			buttonNumber_Click(sender, e);
		}

	}
}
