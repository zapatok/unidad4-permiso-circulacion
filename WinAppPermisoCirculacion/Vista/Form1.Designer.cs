namespace WinAppPermisoCirculacion.Vista
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codigo generado por el Disenador de Windows Forms

        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contribuyentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionContribuyentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionVehiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirDeAplicacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            //
            // menuStrip1
            //
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contribuyentesToolStripMenuItem,
            this.vehiculosToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            //
            // contribuyentesToolStripMenuItem
            //
            this.contribuyentesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionContribuyentesToolStripMenuItem});
            this.contribuyentesToolStripMenuItem.Name = "contribuyentesToolStripMenuItem";
            this.contribuyentesToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.contribuyentesToolStripMenuItem.Text = "Contribuyentes";
            //
            // gestionContribuyentesToolStripMenuItem
            //
            this.gestionContribuyentesToolStripMenuItem.Name = "gestionContribuyentesToolStripMenuItem";
            this.gestionContribuyentesToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.gestionContribuyentesToolStripMenuItem.Text = "Gestion Contribuyentes";
            this.gestionContribuyentesToolStripMenuItem.Click += new System.EventHandler(this.gestionContribuyentesToolStripMenuItem_Click);
            //
            // vehiculosToolStripMenuItem
            //
            this.vehiculosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionVehiculosToolStripMenuItem});
            this.vehiculosToolStripMenuItem.Name = "vehiculosToolStripMenuItem";
            this.vehiculosToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.vehiculosToolStripMenuItem.Text = "Vehiculos";
            //
            // gestionVehiculosToolStripMenuItem
            //
            this.gestionVehiculosToolStripMenuItem.Name = "gestionVehiculosToolStripMenuItem";
            this.gestionVehiculosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gestionVehiculosToolStripMenuItem.Text = "Gestion Vehiculos";
            this.gestionVehiculosToolStripMenuItem.Click += new System.EventHandler(this.gestionVehiculosToolStripMenuItem_Click);
            //
            // salirToolStripMenuItem
            //
            this.salirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirDeAplicacionToolStripMenuItem});
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            //
            // salirDeAplicacionToolStripMenuItem
            //
            this.salirDeAplicacionToolStripMenuItem.Name = "salirDeAplicacionToolStripMenuItem";
            this.salirDeAplicacionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirDeAplicacionToolStripMenuItem.Text = "Salir de Aplicacion";
            this.salirDeAplicacionToolStripMenuItem.Click += new System.EventHandler(this.salirDeAplicacionToolStripMenuItem_Click);
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Permiso de Circulacion";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem contribuyentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionContribuyentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehiculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionVehiculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirDeAplicacionToolStripMenuItem;
    }
}
