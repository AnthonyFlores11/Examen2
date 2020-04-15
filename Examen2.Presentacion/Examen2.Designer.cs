namespace Examen2.Presentacion
{
    partial class Examen2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_Menu = new System.Windows.Forms.Label();
            this.dg_menu = new System.Windows.Forms.DataGridView();
            this.lb_nombre = new System.Windows.Forms.Label();
            this.txb_nombre = new System.Windows.Forms.TextBox();
            this.txb_descripcion = new System.Windows.Forms.TextBox();
            this.lb_descripcion = new System.Windows.Forms.Label();
            this.rb_desayuno = new System.Windows.Forms.RadioButton();
            this.rb_almuerzo = new System.Windows.Forms.RadioButton();
            this.rb_cena = new System.Windows.Forms.RadioButton();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lb_ingredientes = new System.Windows.Forms.Label();
            this.textDescripIngre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textNomIngre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_eliminar_ingrediente = new System.Windows.Forms.Button();
            this.btn_agregar_ingrediente = new System.Windows.Forms.Button();
            this.grbx_Plato = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg_menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grbx_Plato.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_Menu
            // 
            this.lb_Menu.AutoSize = true;
            this.lb_Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Menu.Location = new System.Drawing.Point(15, 24);
            this.lb_Menu.Name = "lb_Menu";
            this.lb_Menu.Size = new System.Drawing.Size(86, 32);
            this.lb_Menu.TabIndex = 0;
            this.lb_Menu.Text = "Menu";
            // 
            // dg_menu
            // 
            this.dg_menu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_menu.Location = new System.Drawing.Point(21, 59);
            this.dg_menu.Name = "dg_menu";
            this.dg_menu.RowHeadersWidth = 51;
            this.dg_menu.RowTemplate.Height = 24;
            this.dg_menu.Size = new System.Drawing.Size(446, 406);
            this.dg_menu.TabIndex = 1;
            // 
            // lb_nombre
            // 
            this.lb_nombre.AutoSize = true;
            this.lb_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nombre.Location = new System.Drawing.Point(16, 485);
            this.lb_nombre.Name = "lb_nombre";
            this.lb_nombre.Size = new System.Drawing.Size(87, 25);
            this.lb_nombre.TabIndex = 2;
            this.lb_nombre.Text = "Nombre:";
            // 
            // txb_nombre
            // 
            this.txb_nombre.Location = new System.Drawing.Point(131, 485);
            this.txb_nombre.Name = "txb_nombre";
            this.txb_nombre.Size = new System.Drawing.Size(336, 22);
            this.txb_nombre.TabIndex = 3;
            // 
            // txb_descripcion
            // 
            this.txb_descripcion.Location = new System.Drawing.Point(131, 530);
            this.txb_descripcion.Name = "txb_descripcion";
            this.txb_descripcion.Size = new System.Drawing.Size(336, 22);
            this.txb_descripcion.TabIndex = 5;
            // 
            // lb_descripcion
            // 
            this.lb_descripcion.AutoSize = true;
            this.lb_descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_descripcion.Location = new System.Drawing.Point(16, 526);
            this.lb_descripcion.Name = "lb_descripcion";
            this.lb_descripcion.Size = new System.Drawing.Size(120, 25);
            this.lb_descripcion.TabIndex = 4;
            this.lb_descripcion.Text = "Descripcion:";
            // 
            // rb_desayuno
            // 
            this.rb_desayuno.AutoSize = true;
            this.rb_desayuno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_desayuno.Location = new System.Drawing.Point(9, 21);
            this.rb_desayuno.Name = "rb_desayuno";
            this.rb_desayuno.Size = new System.Drawing.Size(122, 29);
            this.rb_desayuno.TabIndex = 6;
            this.rb_desayuno.TabStop = true;
            this.rb_desayuno.Text = "Desayuno";
            this.rb_desayuno.UseVisualStyleBackColor = true;
            // 
            // rb_almuerzo
            // 
            this.rb_almuerzo.AutoSize = true;
            this.rb_almuerzo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_almuerzo.Location = new System.Drawing.Point(176, 21);
            this.rb_almuerzo.Name = "rb_almuerzo";
            this.rb_almuerzo.Size = new System.Drawing.Size(116, 29);
            this.rb_almuerzo.TabIndex = 7;
            this.rb_almuerzo.TabStop = true;
            this.rb_almuerzo.Text = "Almuerzo";
            this.rb_almuerzo.UseVisualStyleBackColor = true;
            // 
            // rb_cena
            // 
            this.rb_cena.AutoSize = true;
            this.rb_cena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_cena.Location = new System.Drawing.Point(368, 21);
            this.rb_cena.Name = "rb_cena";
            this.rb_cena.Size = new System.Drawing.Size(81, 29);
            this.rb_cena.TabIndex = 8;
            this.rb_cena.TabStop = true;
            this.rb_cena.Text = "Cena";
            this.rb_cena.UseVisualStyleBackColor = true;
            // 
            // btn_salvar
            // 
            this.btn_salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvar.Location = new System.Drawing.Point(12, 622);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(211, 56);
            this.btn_salvar.TabIndex = 9;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.Location = new System.Drawing.Point(256, 622);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(211, 56);
            this.btn_eliminar.TabIndex = 10;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(549, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(446, 406);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lb_ingredientes
            // 
            this.lb_ingredientes.AutoSize = true;
            this.lb_ingredientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ingredientes.Location = new System.Drawing.Point(543, 24);
            this.lb_ingredientes.Name = "lb_ingredientes";
            this.lb_ingredientes.Size = new System.Drawing.Size(172, 32);
            this.lb_ingredientes.TabIndex = 11;
            this.lb_ingredientes.Text = "Ingredientes";
            // 
            // textDescripIngre
            // 
            this.textDescripIngre.Location = new System.Drawing.Point(664, 527);
            this.textDescripIngre.Name = "textDescripIngre";
            this.textDescripIngre.Size = new System.Drawing.Size(336, 22);
            this.textDescripIngre.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(544, 526);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Descripcion:";
            // 
            // textNomIngre
            // 
            this.textNomIngre.Location = new System.Drawing.Point(664, 482);
            this.textNomIngre.Name = "textNomIngre";
            this.textNomIngre.Size = new System.Drawing.Size(336, 22);
            this.textNomIngre.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(544, 481);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nombre:";
            // 
            // btn_eliminar_ingrediente
            // 
            this.btn_eliminar_ingrediente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar_ingrediente.Location = new System.Drawing.Point(789, 622);
            this.btn_eliminar_ingrediente.Name = "btn_eliminar_ingrediente";
            this.btn_eliminar_ingrediente.Size = new System.Drawing.Size(211, 56);
            this.btn_eliminar_ingrediente.TabIndex = 18;
            this.btn_eliminar_ingrediente.Text = "Eliminar Ingrediente";
            this.btn_eliminar_ingrediente.UseVisualStyleBackColor = true;
            this.btn_eliminar_ingrediente.Click += new System.EventHandler(this.btn_eliminar_ingrediente_Click);
            // 
            // btn_agregar_ingrediente
            // 
            this.btn_agregar_ingrediente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar_ingrediente.Location = new System.Drawing.Point(549, 622);
            this.btn_agregar_ingrediente.Name = "btn_agregar_ingrediente";
            this.btn_agregar_ingrediente.Size = new System.Drawing.Size(211, 56);
            this.btn_agregar_ingrediente.TabIndex = 17;
            this.btn_agregar_ingrediente.Text = "Agregar Ingrediente";
            this.btn_agregar_ingrediente.UseVisualStyleBackColor = true;
            this.btn_agregar_ingrediente.Click += new System.EventHandler(this.btn_agregar_ingrediente_Click);
            // 
            // grbx_Plato
            // 
            this.grbx_Plato.Controls.Add(this.rb_desayuno);
            this.grbx_Plato.Controls.Add(this.rb_almuerzo);
            this.grbx_Plato.Controls.Add(this.rb_cena);
            this.grbx_Plato.Location = new System.Drawing.Point(12, 558);
            this.grbx_Plato.Name = "grbx_Plato";
            this.grbx_Plato.Size = new System.Drawing.Size(455, 60);
            this.grbx_Plato.TabIndex = 19;
            this.grbx_Plato.TabStop = false;
            this.grbx_Plato.Text = "Horario";
            // 
            // Examen2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 696);
            this.Controls.Add(this.grbx_Plato);
            this.Controls.Add(this.btn_eliminar_ingrediente);
            this.Controls.Add(this.btn_agregar_ingrediente);
            this.Controls.Add(this.textDescripIngre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textNomIngre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lb_ingredientes);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.txb_descripcion);
            this.Controls.Add(this.lb_descripcion);
            this.Controls.Add(this.txb_nombre);
            this.Controls.Add(this.lb_nombre);
            this.Controls.Add(this.dg_menu);
            this.Controls.Add(this.lb_Menu);
            this.Name = "Examen2";
            this.Text = "Examen2";
            ((System.ComponentModel.ISupportInitialize)(this.dg_menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grbx_Plato.ResumeLayout(false);
            this.grbx_Plato.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Menu;
        private System.Windows.Forms.DataGridView dg_menu;
        private System.Windows.Forms.Label lb_nombre;
        private System.Windows.Forms.TextBox txb_nombre;
        private System.Windows.Forms.TextBox txb_descripcion;
        private System.Windows.Forms.Label lb_descripcion;
        private System.Windows.Forms.RadioButton rb_desayuno;
        private System.Windows.Forms.RadioButton rb_almuerzo;
        private System.Windows.Forms.RadioButton rb_cena;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lb_ingredientes;
        private System.Windows.Forms.TextBox textDescripIngre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNomIngre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_eliminar_ingrediente;
        private System.Windows.Forms.Button btn_agregar_ingrediente;
        private System.Windows.Forms.GroupBox grbx_Plato;
    }
}