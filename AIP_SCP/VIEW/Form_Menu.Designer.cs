
namespace AIP_SCP
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.uSERToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sALIRToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aGREGARToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lISTARToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pERMISOSSISTEMAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uSUARIOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uSERToolStripMenuItem1,
            this.sALIRToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1055, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // uSERToolStripMenuItem1
            // 
            this.uSERToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aGREGARToolStripMenuItem1,
            this.lISTARToolStripMenuItem1});
            this.uSERToolStripMenuItem1.Name = "uSERToolStripMenuItem1";
            this.uSERToolStripMenuItem1.Size = new System.Drawing.Size(55, 24);
            this.uSERToolStripMenuItem1.Text = "USER";
            // 
            // sALIRToolStripMenuItem1
            // 
            this.sALIRToolStripMenuItem1.Name = "sALIRToolStripMenuItem1";
            this.sALIRToolStripMenuItem1.Size = new System.Drawing.Size(59, 24);
            this.sALIRToolStripMenuItem1.Text = "SALIR";
            // 
            // aGREGARToolStripMenuItem1
            // 
            this.aGREGARToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pERMISOSSISTEMAToolStripMenuItem});
            this.aGREGARToolStripMenuItem1.Name = "aGREGARToolStripMenuItem1";
            this.aGREGARToolStripMenuItem1.Size = new System.Drawing.Size(180, 24);
            this.aGREGARToolStripMenuItem1.Text = "AGREGAR ";
            // 
            // lISTARToolStripMenuItem1
            // 
            this.lISTARToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uSUARIOSToolStripMenuItem});
            this.lISTARToolStripMenuItem1.Name = "lISTARToolStripMenuItem1";
            this.lISTARToolStripMenuItem1.Size = new System.Drawing.Size(180, 24);
            this.lISTARToolStripMenuItem1.Text = "LISTAR";
            // 
            // pERMISOSSISTEMAToolStripMenuItem
            // 
            this.pERMISOSSISTEMAToolStripMenuItem.Name = "pERMISOSSISTEMAToolStripMenuItem";
            this.pERMISOSSISTEMAToolStripMenuItem.Size = new System.Drawing.Size(203, 24);
            this.pERMISOSSISTEMAToolStripMenuItem.Text = "PERMISOS SISTEMA";
            // 
            // uSUARIOSToolStripMenuItem
            // 
            this.uSUARIOSToolStripMenuItem.Name = "uSUARIOSToolStripMenuItem";
            this.uSUARIOSToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.uSUARIOSToolStripMenuItem.Text = "USUARIOS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(261, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 73);
            this.label1.TabIndex = 2;
            this.label1.Text = "BIENVENIDO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 518);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem uSERToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aGREGARToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pERMISOSSISTEMAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lISTARToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem uSUARIOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sALIRToolStripMenuItem1;
        private System.Windows.Forms.Label label1;
    }
}

