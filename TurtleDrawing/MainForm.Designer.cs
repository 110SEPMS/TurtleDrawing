namespace TurtleDrawing
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.DrawTree_Btn = new System.Windows.Forms.Button();
            this.Clear_Btn = new System.Windows.Forms.Button();
            this.DrawKoch_Btn = new System.Windows.Forms.Button();
            this.DrawFern_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DrawTree_Btn
            // 
            this.DrawTree_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DrawTree_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DrawTree_Btn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DrawTree_Btn.Location = new System.Drawing.Point(11, 11);
            this.DrawTree_Btn.Margin = new System.Windows.Forms.Padding(2);
            this.DrawTree_Btn.Name = "DrawTree_Btn";
            this.DrawTree_Btn.Size = new System.Drawing.Size(145, 39);
            this.DrawTree_Btn.TabIndex = 4;
            this.DrawTree_Btn.Text = "Tree";
            this.DrawTree_Btn.UseVisualStyleBackColor = false;
            this.DrawTree_Btn.Click += new System.EventHandler(this.DrawTree_Btn_Click);
            // 
            // Clear_Btn
            // 
            this.Clear_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Clear_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear_Btn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Clear_Btn.Location = new System.Drawing.Point(458, 11);
            this.Clear_Btn.Margin = new System.Windows.Forms.Padding(2);
            this.Clear_Btn.Name = "Clear_Btn";
            this.Clear_Btn.Size = new System.Drawing.Size(145, 39);
            this.Clear_Btn.TabIndex = 5;
            this.Clear_Btn.Text = "Clear";
            this.Clear_Btn.UseVisualStyleBackColor = false;
            this.Clear_Btn.Click += new System.EventHandler(this.Clear_Btn_Click);
            // 
            // DrawKoch_Btn
            // 
            this.DrawKoch_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.DrawKoch_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DrawKoch_Btn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DrawKoch_Btn.Location = new System.Drawing.Point(309, 11);
            this.DrawKoch_Btn.Margin = new System.Windows.Forms.Padding(2);
            this.DrawKoch_Btn.Name = "DrawKoch_Btn";
            this.DrawKoch_Btn.Size = new System.Drawing.Size(145, 39);
            this.DrawKoch_Btn.TabIndex = 6;
            this.DrawKoch_Btn.Text = "Koch Island";
            this.DrawKoch_Btn.UseVisualStyleBackColor = false;
            this.DrawKoch_Btn.Click += new System.EventHandler(this.DrawKochIsland_Btn_Click);
            // 
            // DrawFern_Btn
            // 
            this.DrawFern_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.DrawFern_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DrawFern_Btn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DrawFern_Btn.Location = new System.Drawing.Point(160, 11);
            this.DrawFern_Btn.Margin = new System.Windows.Forms.Padding(2);
            this.DrawFern_Btn.Name = "DrawFern_Btn";
            this.DrawFern_Btn.Size = new System.Drawing.Size(145, 39);
            this.DrawFern_Btn.TabIndex = 7;
            this.DrawFern_Btn.Text = "Fern";
            this.DrawFern_Btn.UseVisualStyleBackColor = false;
            this.DrawFern_Btn.Click += new System.EventHandler(this.DrawFern_Btn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 572);
            this.Controls.Add(this.DrawFern_Btn);
            this.Controls.Add(this.DrawKoch_Btn);
            this.Controls.Add(this.Clear_Btn);
            this.Controls.Add(this.DrawTree_Btn);
            this.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TurtleCS";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button DrawTree_Btn;
        private System.Windows.Forms.Button Clear_Btn;
        private System.Windows.Forms.Button DrawKoch_Btn;
        private System.Windows.Forms.Button DrawFern_Btn;
    }
}

