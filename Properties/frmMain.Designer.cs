
namespace SQL_to_String_Builder
{
    partial class frmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.edtOriginalText = new DevExpress.XtraEditors.MemoEdit();
            this.edtConvertedText = new DevExpress.XtraEditors.MemoEdit();
            this.btnConvert = new DevExpress.XtraEditors.SimpleButton();
            this.pbConvert = new System.Windows.Forms.PictureBox();
            this.btnCopyToClipboard = new DevExpress.XtraEditors.SimpleButton();
            this.rgSelection = new DevExpress.XtraEditors.RadioGroup();
            this.rbSQLtoSB = new System.Windows.Forms.RadioButton();
            this.rbSBtoSQL = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.edtOriginalText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtConvertedText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConvert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgSelection.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // edtOriginalText
            // 
            this.edtOriginalText.Location = new System.Drawing.Point(12, 62);
            this.edtOriginalText.Name = "edtOriginalText";
            this.edtOriginalText.Properties.Appearance.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtOriginalText.Properties.Appearance.Options.UseFont = true;
            this.edtOriginalText.Size = new System.Drawing.Size(680, 165);
            this.edtOriginalText.TabIndex = 0;
            // 
            // edtConvertedText
            // 
            this.edtConvertedText.Location = new System.Drawing.Point(12, 295);
            this.edtConvertedText.Name = "edtConvertedText";
            this.edtConvertedText.Properties.Appearance.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtConvertedText.Properties.Appearance.Options.UseFont = true;
            this.edtConvertedText.Size = new System.Drawing.Size(680, 165);
            this.edtConvertedText.TabIndex = 1;
            // 
            // btnConvert
            // 
            this.btnConvert.Appearance.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.Appearance.Options.UseFont = true;
            this.btnConvert.Location = new System.Drawing.Point(325, 251);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(70, 23);
            this.btnConvert.TabIndex = 2;
            this.btnConvert.Text = "Convert";
            // 
            // pbConvert
            // 
            this.pbConvert.BackgroundImage = global::SQL_to_String_Builder.Properties.Resources.convert;
            this.pbConvert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbConvert.Location = new System.Drawing.Point(271, 241);
            this.pbConvert.Name = "pbConvert";
            this.pbConvert.Size = new System.Drawing.Size(48, 48);
            this.pbConvert.TabIndex = 3;
            this.pbConvert.TabStop = false;
            // 
            // btnCopyToClipboard
            // 
            this.btnCopyToClipboard.Appearance.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopyToClipboard.Appearance.Options.UseFont = true;
            this.btnCopyToClipboard.Location = new System.Drawing.Point(290, 466);
            this.btnCopyToClipboard.Name = "btnCopyToClipboard";
            this.btnCopyToClipboard.Size = new System.Drawing.Size(140, 23);
            this.btnCopyToClipboard.TabIndex = 4;
            this.btnCopyToClipboard.Text = "Copy to Clipboard";
            // 
            // rgSelection
            // 
            this.rgSelection.Location = new System.Drawing.Point(13, 13);
            this.rgSelection.Name = "rgSelection";
            this.rgSelection.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.rgSelection.Properties.Appearance.Options.UseBackColor = true;
            this.rgSelection.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.rgSelection.Size = new System.Drawing.Size(679, 43);
            this.rgSelection.TabIndex = 5;
            // 
            // rbSQLtoSB
            // 
            this.rbSQLtoSB.AutoSize = true;
            this.rbSQLtoSB.Location = new System.Drawing.Point(25, 26);
            this.rbSQLtoSB.Name = "rbSQLtoSB";
            this.rbSQLtoSB.Size = new System.Drawing.Size(126, 17);
            this.rbSQLtoSB.TabIndex = 6;
            this.rbSQLtoSB.TabStop = true;
            this.rbSQLtoSB.Text = "SQL  to String Builder";
            this.rbSQLtoSB.UseVisualStyleBackColor = true;
            // 
            // rbSBtoSQL
            // 
            this.rbSBtoSQL.AutoSize = true;
            this.rbSBtoSQL.Location = new System.Drawing.Point(216, 26);
            this.rbSBtoSQL.Name = "rbSBtoSQL";
            this.rbSBtoSQL.Size = new System.Drawing.Size(123, 17);
            this.rbSBtoSQL.TabIndex = 7;
            this.rbSBtoSQL.TabStop = true;
            this.rbSBtoSQL.Text = "String Builder to SQL";
            this.rbSBtoSQL.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 501);
            this.Controls.Add(this.rbSBtoSQL);
            this.Controls.Add(this.rbSQLtoSB);
            this.Controls.Add(this.rgSelection);
            this.Controls.Add(this.btnCopyToClipboard);
            this.Controls.Add(this.pbConvert);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.edtConvertedText);
            this.Controls.Add(this.edtOriginalText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(720, 540);
            this.MinimumSize = new System.Drawing.Size(720, 540);
            this.Name = "frmMain";
            this.Text = "SQL to String Builder";
            ((System.ComponentModel.ISupportInitialize)(this.edtOriginalText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtConvertedText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConvert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgSelection.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.MemoEdit edtOriginalText;
        private DevExpress.XtraEditors.MemoEdit edtConvertedText;
        private DevExpress.XtraEditors.SimpleButton btnConvert;
        private System.Windows.Forms.PictureBox pbConvert;
        private DevExpress.XtraEditors.SimpleButton btnCopyToClipboard;
        private DevExpress.XtraEditors.RadioGroup rgSelection;
        private System.Windows.Forms.RadioButton rbSQLtoSB;
        private System.Windows.Forms.RadioButton rbSBtoSQL;
    }
}

