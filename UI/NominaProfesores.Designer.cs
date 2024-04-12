namespace UI
{
    partial class FrmNominaProfesores
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
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.txtPrecioHoras = new MaterialSkin.Controls.MaterialTextBox();
            this.txtHorasTrabjadas = new MaterialSkin.Controls.MaterialTextBox();
            this.txtApellido = new MaterialSkin.Controls.MaterialTextBox();
            this.txtNombre = new MaterialSkin.Controls.MaterialTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BtnBorrar = new MaterialSkin.Controls.MaterialButton();
            this.BtnListar = new MaterialSkin.Controls.MaterialButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.materialTextBox12 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox11 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(833, 662);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.materialButton2);
            this.tabPage1.Controls.Add(this.txtPrecioHoras);
            this.tabPage1.Controls.Add(this.txtHorasTrabjadas);
            this.tabPage1.Controls.Add(this.txtApellido);
            this.tabPage1.Controls.Add(this.txtNombre);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(825, 633);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Profesores";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSize = false;
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.materialButton2.Depth = 0;
            this.materialButton2.DrawShadows = false;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(412, 317);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(173, 39);
            this.materialButton2.TabIndex = 12;
            this.materialButton2.Text = "Agregar Profesor";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = true;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // txtPrecioHoras
            // 
            this.txtPrecioHoras.AnimateReadOnly = false;
            this.txtPrecioHoras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrecioHoras.Depth = 0;
            this.txtPrecioHoras.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrecioHoras.Hint = "Precio Horas";
            this.txtPrecioHoras.LeadingIcon = null;
            this.txtPrecioHoras.Location = new System.Drawing.Point(231, 259);
            this.txtPrecioHoras.MaxLength = 50;
            this.txtPrecioHoras.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPrecioHoras.Multiline = false;
            this.txtPrecioHoras.Name = "txtPrecioHoras";
            this.txtPrecioHoras.Size = new System.Drawing.Size(354, 36);
            this.txtPrecioHoras.TabIndex = 5;
            this.txtPrecioHoras.Text = "";
            this.txtPrecioHoras.TrailingIcon = null;
            this.txtPrecioHoras.UseTallSize = false;
            // 
            // txtHorasTrabjadas
            // 
            this.txtHorasTrabjadas.AnimateReadOnly = false;
            this.txtHorasTrabjadas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHorasTrabjadas.Depth = 0;
            this.txtHorasTrabjadas.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtHorasTrabjadas.Hint = "Horas Trabajadas";
            this.txtHorasTrabjadas.LeadingIcon = null;
            this.txtHorasTrabjadas.Location = new System.Drawing.Point(231, 196);
            this.txtHorasTrabjadas.MaxLength = 50;
            this.txtHorasTrabjadas.MouseState = MaterialSkin.MouseState.OUT;
            this.txtHorasTrabjadas.Multiline = false;
            this.txtHorasTrabjadas.Name = "txtHorasTrabjadas";
            this.txtHorasTrabjadas.Size = new System.Drawing.Size(354, 36);
            this.txtHorasTrabjadas.TabIndex = 4;
            this.txtHorasTrabjadas.Text = "";
            this.txtHorasTrabjadas.TrailingIcon = null;
            this.txtHorasTrabjadas.UseTallSize = false;
            // 
            // txtApellido
            // 
            this.txtApellido.AnimateReadOnly = false;
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellido.Depth = 0;
            this.txtApellido.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtApellido.Hint = "Apellido";
            this.txtApellido.LeadingIcon = null;
            this.txtApellido.Location = new System.Drawing.Point(231, 136);
            this.txtApellido.MaxLength = 50;
            this.txtApellido.MouseState = MaterialSkin.MouseState.OUT;
            this.txtApellido.Multiline = false;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(354, 36);
            this.txtApellido.TabIndex = 3;
            this.txtApellido.Text = "";
            this.txtApellido.TrailingIcon = null;
            this.txtApellido.UseTallSize = false;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.AnimateReadOnly = false;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Depth = 0;
            this.txtNombre.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombre.Hint = "Nombre";
            this.txtNombre.LeadingIcon = null;
            this.txtNombre.Location = new System.Drawing.Point(231, 77);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombre.Multiline = false;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(354, 36);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.Text = "";
            this.txtNombre.TrailingIcon = null;
            this.txtNombre.UseTallSize = false;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.BtnBorrar);
            this.tabPage2.Controls.Add(this.BtnListar);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.materialTextBox12);
            this.tabPage2.Controls.Add(this.materialTextBox11);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(825, 633);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Nomina";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // BtnBorrar
            // 
            this.BtnBorrar.AutoSize = false;
            this.BtnBorrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnBorrar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.BtnBorrar.Depth = 0;
            this.BtnBorrar.DrawShadows = false;
            this.BtnBorrar.HighEmphasis = true;
            this.BtnBorrar.Icon = null;
            this.BtnBorrar.Location = new System.Drawing.Point(494, 468);
            this.BtnBorrar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnBorrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnBorrar.Name = "BtnBorrar";
            this.BtnBorrar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnBorrar.Size = new System.Drawing.Size(140, 39);
            this.BtnBorrar.TabIndex = 15;
            this.BtnBorrar.Text = "Borrar";
            this.BtnBorrar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnBorrar.UseAccentColor = true;
            this.BtnBorrar.UseVisualStyleBackColor = true;
            this.BtnBorrar.Click += new System.EventHandler(this.BtnBorrar_Click);
            // 
            // BtnListar
            // 
            this.BtnListar.AutoSize = false;
            this.BtnListar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnListar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.BtnListar.Depth = 0;
            this.BtnListar.DrawShadows = false;
            this.BtnListar.HighEmphasis = true;
            this.BtnListar.Icon = null;
            this.BtnListar.Location = new System.Drawing.Point(666, 468);
            this.BtnListar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnListar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnListar.Name = "BtnListar";
            this.BtnListar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnListar.Size = new System.Drawing.Size(126, 39);
            this.BtnListar.TabIndex = 13;
            this.BtnListar.Text = "Imprimir";
            this.BtnListar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnListar.UseAccentColor = true;
            this.BtnListar.UseVisualStyleBackColor = true;
            this.BtnListar.Click += new System.EventHandler(this.BtnListar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(56, 181);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(736, 278);
            this.dataGridView1.TabIndex = 4;
            // 
            // materialTextBox12
            // 
            this.materialTextBox12.AnimateReadOnly = false;
            this.materialTextBox12.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox12.Depth = 0;
            this.materialTextBox12.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox12.Hint = "Mes";
            this.materialTextBox12.LeadingIcon = null;
            this.materialTextBox12.Location = new System.Drawing.Point(253, 126);
            this.materialTextBox12.MaxLength = 50;
            this.materialTextBox12.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox12.Multiline = false;
            this.materialTextBox12.Name = "materialTextBox12";
            this.materialTextBox12.Size = new System.Drawing.Size(354, 36);
            this.materialTextBox12.TabIndex = 3;
            this.materialTextBox12.Text = "";
            this.materialTextBox12.TrailingIcon = null;
            this.materialTextBox12.UseTallSize = false;
            // 
            // materialTextBox11
            // 
            this.materialTextBox11.AnimateReadOnly = false;
            this.materialTextBox11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox11.Depth = 0;
            this.materialTextBox11.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox11.Hint = "Fecha";
            this.materialTextBox11.LeadingIcon = null;
            this.materialTextBox11.Location = new System.Drawing.Point(253, 69);
            this.materialTextBox11.MaxLength = 50;
            this.materialTextBox11.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox11.Multiline = false;
            this.materialTextBox11.Name = "materialTextBox11";
            this.materialTextBox11.Size = new System.Drawing.Size(354, 36);
            this.materialTextBox11.TabIndex = 2;
            this.materialTextBox11.Text = "";
            this.materialTextBox11.TrailingIcon = null;
            this.materialTextBox11.UseTallSize = false;
            // 
            // FrmNominaProfesores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 728);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerTabControl = this.materialTabControl1;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmNominaProfesores";
            this.Padding = new System.Windows.Forms.Padding(3, 64, 2, 2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nomina Profesores";
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialTextBox txtPrecioHoras;
        private MaterialSkin.Controls.MaterialTextBox txtHorasTrabjadas;
        private MaterialSkin.Controls.MaterialTextBox txtApellido;
        private MaterialSkin.Controls.MaterialTextBox txtNombre;
        private MaterialSkin.Controls.MaterialButton BtnBorrar;
        private MaterialSkin.Controls.MaterialButton BtnListar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox12;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox11;
        private MaterialSkin.Controls.MaterialButton materialButton2;
    }
}

