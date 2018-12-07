namespace object1130
{
	partial class Form1
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.txtIndex = new System.Windows.Forms.TextBox();
			this.buttonHello = new System.Windows.Forms.Button();
			this.buttonAction = new System.Windows.Forms.Button();
			this.buttonNumber = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			//
			// txtIndex
			//
			this.txtIndex.Location = new System.Drawing.Point(12, 12);
			this.txtIndex.Name = "txtIndex";
			this.txtIndex.Size = new System.Drawing.Size(100, 19);
			this.txtIndex.TabIndex = 0;
			this.txtIndex.Text = "0";
			//
			// buttonHello
			//
			this.buttonHello.Location = new System.Drawing.Point(12, 37);
			this.buttonHello.Name = "buttonHello";
			this.buttonHello.Size = new System.Drawing.Size(75, 23);
			this.buttonHello.TabIndex = 1;
			this.buttonHello.Text = "あいさつ";
			this.buttonHello.UseVisualStyleBackColor = true;
			this.buttonHello.Click += new System.EventHandler(this.buttonHello_Click);
			//
			// buttonAction
			//
			this.buttonAction.Location = new System.Drawing.Point(93, 37);
			this.buttonAction.Name = "buttonAction";
			this.buttonAction.Size = new System.Drawing.Size(72, 23);
			this.buttonAction.TabIndex = 2;
			this.buttonAction.Text = "行動";
			this.buttonAction.UseVisualStyleBackColor = true;
			this.buttonAction.Click += new System.EventHandler(this.buttonAction_Click_1);
			//
			// buttonNumber
			//
			this.buttonNumber.Location = new System.Drawing.Point(203, 37);
			this.buttonNumber.Name = "buttonNumber";
			this.buttonNumber.Size = new System.Drawing.Size(75, 23);
			this.buttonNumber.TabIndex = 3;
			this.buttonNumber.Text = "数";
			this.buttonNumber.UseVisualStyleBackColor = true;
			this.buttonNumber.Click += new System.EventHandler(this.buttonNumber_Click_1);
			//
			// textBox1
			//
			this.textBox1.Location = new System.Drawing.Point(12, 66);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(410, 377);
			this.textBox1.TabIndex = 4;
			//
			// Form1
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(434, 455);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.buttonNumber);
			this.Controls.Add(this.buttonAction);
			this.Controls.Add(this.buttonHello);
			this.Controls.Add(this.txtIndex);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load_1);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtIndex;
		private System.Windows.Forms.Button buttonHello;
		private System.Windows.Forms.Button buttonAction;
		private System.Windows.Forms.Button buttonNumber;
		private System.Windows.Forms.TextBox textBox1;
	}
}

