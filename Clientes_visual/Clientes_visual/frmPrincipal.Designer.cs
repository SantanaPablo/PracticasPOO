namespace Clientes_visual
{
    partial class frmPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.txbNombre_Legal = new System.Windows.Forms.TextBox();
            this.lblNombre_Legal = new System.Windows.Forms.Label();
            this.txbNombreFantasia = new System.Windows.Forms.TextBox();
            this.lblNombre_Fantasia = new System.Windows.Forms.Label();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.txbVendedor = new System.Windows.Forms.TextBox();
            this.txbCuit = new System.Windows.Forms.TextBox();
            this.lblCUIT = new System.Windows.Forms.Label();
            this.txbIva = new System.Windows.Forms.TextBox();
            this.lblIva = new System.Windows.Forms.Label();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.txbDomicilio = new System.Windows.Forms.TextBox();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btsTransportes = new System.Windows.Forms.Button();
            this.btnVendedores = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.pnlTopMenu = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txbNombre_Legal
            // 
            this.txbNombre_Legal.Location = new System.Drawing.Point(241, 114);
            this.txbNombre_Legal.MaxLength = 50;
            this.txbNombre_Legal.Name = "txbNombre_Legal";
            this.txbNombre_Legal.ReadOnly = true;
            this.txbNombre_Legal.Size = new System.Drawing.Size(150, 20);
            this.txbNombre_Legal.TabIndex = 0;
            // 
            // lblNombre_Legal
            // 
            this.lblNombre_Legal.AutoSize = true;
            this.lblNombre_Legal.Location = new System.Drawing.Point(162, 117);
            this.lblNombre_Legal.Name = "lblNombre_Legal";
            this.lblNombre_Legal.Size = new System.Drawing.Size(73, 13);
            this.lblNombre_Legal.TabIndex = 1;
            this.lblNombre_Legal.Text = "Nombre Legal";
            // 
            // txbNombreFantasia
            // 
            this.txbNombreFantasia.Location = new System.Drawing.Point(241, 140);
            this.txbNombreFantasia.MaxLength = 50;
            this.txbNombreFantasia.Name = "txbNombreFantasia";
            this.txbNombreFantasia.ReadOnly = true;
            this.txbNombreFantasia.Size = new System.Drawing.Size(150, 20);
            this.txbNombreFantasia.TabIndex = 2;
            // 
            // lblNombre_Fantasia
            // 
            this.lblNombre_Fantasia.AutoSize = true;
            this.lblNombre_Fantasia.Location = new System.Drawing.Point(146, 143);
            this.lblNombre_Fantasia.Name = "lblNombre_Fantasia";
            this.lblNombre_Fantasia.Size = new System.Drawing.Size(89, 13);
            this.lblNombre_Fantasia.TabIndex = 3;
            this.lblNombre_Fantasia.Text = "Nombre Fantasía";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.bindingSource1;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 536);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(784, 25);
            this.bindingNavigator1.TabIndex = 4;
            this.bindingNavigator1.Text = "nvgClientes";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            this.bindingNavigatorMoveFirstItem.Click += new System.EventHandler(this.bindingNavigatorMoveFirstItem_Click);
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            this.bindingNavigatorMovePreviousItem.Click += new System.EventHandler(this.bindingNavigatorMovePreviousItem_Click);
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.bindingNavigatorMoveNextItem_Click);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            this.bindingNavigatorMoveLastItem.Click += new System.EventHandler(this.bindingNavigatorMoveLastItem_Click);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // txbVendedor
            // 
            this.txbVendedor.Location = new System.Drawing.Point(241, 244);
            this.txbVendedor.MaxLength = 50;
            this.txbVendedor.Name = "txbVendedor";
            this.txbVendedor.ReadOnly = true;
            this.txbVendedor.Size = new System.Drawing.Size(100, 20);
            this.txbVendedor.TabIndex = 6;
            // 
            // txbCuit
            // 
            this.txbCuit.Location = new System.Drawing.Point(241, 166);
            this.txbCuit.MaxLength = 50;
            this.txbCuit.Name = "txbCuit";
            this.txbCuit.ReadOnly = true;
            this.txbCuit.Size = new System.Drawing.Size(100, 20);
            this.txbCuit.TabIndex = 8;
            // 
            // lblCUIT
            // 
            this.lblCUIT.AutoSize = true;
            this.lblCUIT.Location = new System.Drawing.Point(200, 169);
            this.lblCUIT.Name = "lblCUIT";
            this.lblCUIT.Size = new System.Drawing.Size(32, 13);
            this.lblCUIT.TabIndex = 9;
            this.lblCUIT.Text = "CUIT";
            // 
            // txbIva
            // 
            this.txbIva.Location = new System.Drawing.Point(241, 192);
            this.txbIva.MaxLength = 50;
            this.txbIva.Name = "txbIva";
            this.txbIva.ReadOnly = true;
            this.txbIva.Size = new System.Drawing.Size(50, 20);
            this.txbIva.TabIndex = 10;
            // 
            // lblIva
            // 
            this.lblIva.AutoSize = true;
            this.lblIva.Location = new System.Drawing.Point(200, 198);
            this.lblIva.Name = "lblIva";
            this.lblIva.Size = new System.Drawing.Size(24, 13);
            this.lblIva.TabIndex = 11;
            this.lblIva.Text = "IVA";
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.AutoSize = true;
            this.lblDomicilio.Location = new System.Drawing.Point(186, 221);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(49, 13);
            this.lblDomicilio.TabIndex = 12;
            this.lblDomicilio.Text = "Domicilio";
            // 
            // txbDomicilio
            // 
            this.txbDomicilio.Location = new System.Drawing.Point(241, 218);
            this.txbDomicilio.MaxLength = 50;
            this.txbDomicilio.Name = "txbDomicilio";
            this.txbDomicilio.ReadOnly = true;
            this.txbDomicilio.Size = new System.Drawing.Size(150, 20);
            this.txbDomicilio.TabIndex = 13;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(75)))), ((int)(((byte)(146)))));
            this.pnlMenu.Controls.Add(this.btsTransportes);
            this.pnlMenu.Controls.Add(this.btnVendedores);
            this.pnlMenu.Controls.Add(this.btnClientes);
            this.pnlMenu.Controls.Add(this.pnlTopMenu);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(140, 536);
            this.pnlMenu.TabIndex = 14;
            // 
            // btsTransportes
            // 
            this.btsTransportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btsTransportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btsTransportes.Font = new System.Drawing.Font("electrical", 6.25F);
            this.btsTransportes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btsTransportes.Location = new System.Drawing.Point(0, 200);
            this.btsTransportes.Name = "btsTransportes";
            this.btsTransportes.Size = new System.Drawing.Size(140, 50);
            this.btsTransportes.TabIndex = 3;
            this.btsTransportes.Text = "Transportes";
            this.btsTransportes.UseVisualStyleBackColor = true;
            // 
            // btnVendedores
            // 
            this.btnVendedores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVendedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVendedores.Font = new System.Drawing.Font("electrical", 6.25F);
            this.btnVendedores.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVendedores.Location = new System.Drawing.Point(0, 150);
            this.btnVendedores.Name = "btnVendedores";
            this.btnVendedores.Size = new System.Drawing.Size(140, 50);
            this.btnVendedores.TabIndex = 2;
            this.btnVendedores.Text = "Vendedores";
            this.btnVendedores.UseVisualStyleBackColor = true;
            // 
            // btnClientes
            // 
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("electrical", 6.25F);
            this.btnClientes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClientes.Location = new System.Drawing.Point(0, 100);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(140, 50);
            this.btnClientes.TabIndex = 1;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            // 
            // pnlTopMenu
            // 
            this.pnlTopMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlTopMenu.Name = "pnlTopMenu";
            this.pnlTopMenu.Size = new System.Drawing.Size(140, 100);
            this.pnlTopMenu.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Clientes_visual.Properties.Resources.doctor_Cable1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(138, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(646, 100);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(229, 494);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 16;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Location = new System.Drawing.Point(182, 247);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(53, 13);
            this.lblVendedor.TabIndex = 17;
            this.lblVendedor.Text = "Vendedor";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(315, 494);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 19;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.lblVendedor);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.txbDomicilio);
            this.Controls.Add(this.lblDomicilio);
            this.Controls.Add(this.lblIva);
            this.Controls.Add(this.txbIva);
            this.Controls.Add(this.lblCUIT);
            this.Controls.Add(this.txbCuit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txbVendedor);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.lblNombre_Fantasia);
            this.Controls.Add(this.txbNombreFantasia);
            this.Controls.Add(this.lblNombre_Legal);
            this.Controls.Add(this.txbNombre_Legal);
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbNombre_Legal;
        private System.Windows.Forms.Label lblNombre_Legal;
        private System.Windows.Forms.TextBox txbNombreFantasia;
        private System.Windows.Forms.Label lblNombre_Fantasia;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox txbVendedor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txbCuit;
        private System.Windows.Forms.Label lblCUIT;
        private System.Windows.Forms.TextBox txbIva;
        private System.Windows.Forms.Label lblIva;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.TextBox txbDomicilio;
        private System.Windows.Forms.Panel pnlTopMenu;
        private System.Windows.Forms.Button btnVendedores;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btsTransportes;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.Button btnModificar;
    }
}

