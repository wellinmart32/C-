
namespace PruebaPokemon
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPokemon = new System.Windows.Forms.TextBox();
            this.pokemonlist = new System.Windows.Forms.ListView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filtrar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pokedex";
            // 
            // txtPokemon
            // 
            this.txtPokemon.Location = new System.Drawing.Point(75, 75);
            this.txtPokemon.Name = "txtPokemon";
            this.txtPokemon.Size = new System.Drawing.Size(422, 22);
            this.txtPokemon.TabIndex = 2;
            this.txtPokemon.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pokemonlist
            // 
            this.pokemonlist.HideSelection = false;
            this.pokemonlist.Location = new System.Drawing.Point(75, 153);
            this.pokemonlist.Name = "pokemonlist";
            this.pokemonlist.Size = new System.Drawing.Size(552, 249);
            this.pokemonlist.TabIndex = 3;
            this.pokemonlist.UseCompatibleStateImageBehavior = false;
            this.pokemonlist.View = System.Windows.Forms.View.SmallIcon;
            this.pokemonlist.SelectedIndexChanged += new System.EventHandler(this.pokemonlist_SelectedIndexChanged);
            this.pokemonlist.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pokemonlist_MouseClick);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(503, 74);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.pokemonlist);
            this.Controls.Add(this.txtPokemon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPokemon;
        private System.Windows.Forms.ListView pokemonlist;
        private System.Windows.Forms.Button btnBuscar;
    }
}

