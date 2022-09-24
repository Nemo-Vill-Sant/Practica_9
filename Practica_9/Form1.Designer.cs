
namespace Practica_9
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
            this.components = new System.ComponentModel.Container();
            this.labelID = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelDUI = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDUI = new System.Windows.Forms.TextBox();
            this.btGuardar = new System.Windows.Forms.Button();
            this.labelRegistro = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btAFP = new System.Windows.Forms.Button();
            this.txtAFP = new System.Windows.Forms.TextBox();
            this.labelSalario = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.btISSS = new System.Windows.Forms.Button();
            this.txtISSS = new System.Windows.Forms.TextBox();
            this.txtNeto = new System.Windows.Forms.TextBox();
            this.btNeto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(53, 72);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(26, 20);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "ID";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(53, 120);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(65, 20);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Text = "Nombre";
            // 
            // labelDUI
            // 
            this.labelDUI.AutoSize = true;
            this.labelDUI.Location = new System.Drawing.Point(62, 169);
            this.labelDUI.Name = "labelDUI";
            this.labelDUI.Size = new System.Drawing.Size(38, 20);
            this.labelDUI.TabIndex = 2;
            this.labelDUI.Text = "DUI";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(183, 65);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 26);
            this.txtID.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(183, 114);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 26);
            this.txtNombre.TabIndex = 4;
            // 
            // txtDUI
            // 
            this.txtDUI.Location = new System.Drawing.Point(183, 163);
            this.txtDUI.Name = "txtDUI";
            this.txtDUI.Size = new System.Drawing.Size(100, 26);
            this.txtDUI.TabIndex = 5;
            // 
            // btGuardar
            // 
            this.btGuardar.Location = new System.Drawing.Point(183, 300);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(88, 39);
            this.btGuardar.TabIndex = 6;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // labelRegistro
            // 
            this.labelRegistro.AutoSize = true;
            this.labelRegistro.Location = new System.Drawing.Point(434, 266);
            this.labelRegistro.Name = "labelRegistro";
            this.labelRegistro.Size = new System.Drawing.Size(0, 20);
            this.labelRegistro.TabIndex = 7;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btAFP
            // 
            this.btAFP.Location = new System.Drawing.Point(377, 60);
            this.btAFP.Name = "btAFP";
            this.btAFP.Size = new System.Drawing.Size(75, 36);
            this.btAFP.TabIndex = 8;
            this.btAFP.Text = "AFP";
            this.btAFP.UseVisualStyleBackColor = true;
            this.btAFP.Click += new System.EventHandler(this.btAFP_Click);
            // 
            // txtAFP
            // 
            this.txtAFP.Location = new System.Drawing.Point(496, 65);
            this.txtAFP.Name = "txtAFP";
            this.txtAFP.Size = new System.Drawing.Size(100, 26);
            this.txtAFP.TabIndex = 9;
            // 
            // labelSalario
            // 
            this.labelSalario.AutoSize = true;
            this.labelSalario.Location = new System.Drawing.Point(60, 214);
            this.labelSalario.Name = "labelSalario";
            this.labelSalario.Size = new System.Drawing.Size(58, 20);
            this.labelSalario.TabIndex = 10;
            this.labelSalario.Text = "Salario";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(183, 211);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(100, 26);
            this.txtSalario.TabIndex = 11;
            // 
            // btISSS
            // 
            this.btISSS.Location = new System.Drawing.Point(377, 123);
            this.btISSS.Name = "btISSS";
            this.btISSS.Size = new System.Drawing.Size(75, 37);
            this.btISSS.TabIndex = 12;
            this.btISSS.Text = "ISSS";
            this.btISSS.UseVisualStyleBackColor = true;
            this.btISSS.Click += new System.EventHandler(this.btISSS_Click);
            // 
            // txtISSS
            // 
            this.txtISSS.Location = new System.Drawing.Point(496, 128);
            this.txtISSS.Name = "txtISSS";
            this.txtISSS.Size = new System.Drawing.Size(100, 26);
            this.txtISSS.TabIndex = 13;
            // 
            // txtNeto
            // 
            this.txtNeto.Location = new System.Drawing.Point(496, 193);
            this.txtNeto.Name = "txtNeto";
            this.txtNeto.Size = new System.Drawing.Size(100, 26);
            this.txtNeto.TabIndex = 14;
            // 
            // btNeto
            // 
            this.btNeto.Location = new System.Drawing.Point(377, 187);
            this.btNeto.Name = "btNeto";
            this.btNeto.Size = new System.Drawing.Size(75, 39);
            this.btNeto.TabIndex = 15;
            this.btNeto.Text = "Neto";
            this.btNeto.UseVisualStyleBackColor = true;
            this.btNeto.Click += new System.EventHandler(this.btNeto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btNeto);
            this.Controls.Add(this.txtNeto);
            this.Controls.Add(this.txtISSS);
            this.Controls.Add(this.btISSS);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.labelSalario);
            this.Controls.Add(this.txtAFP);
            this.Controls.Add(this.btAFP);
            this.Controls.Add(this.labelRegistro);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.txtDUI);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.labelDUI);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelID);
            this.Name = "Form1";
            this.Text = "Registro de empleados";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelDUI;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDUI;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Label labelRegistro;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtAFP;
        private System.Windows.Forms.Button btAFP;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label labelSalario;
        private System.Windows.Forms.TextBox txtISSS;
        private System.Windows.Forms.Button btISSS;
        private System.Windows.Forms.Button btNeto;
        private System.Windows.Forms.TextBox txtNeto;
    }
}

