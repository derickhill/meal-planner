
namespace Meal_Planner
{
    partial class frmInitial
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
            this.btnGeneratePlan = new System.Windows.Forms.Button();
            this.btnAddMeal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGeneratePlan
            // 
            this.btnGeneratePlan.Location = new System.Drawing.Point(310, 152);
            this.btnGeneratePlan.Name = "btnGeneratePlan";
            this.btnGeneratePlan.Size = new System.Drawing.Size(173, 23);
            this.btnGeneratePlan.TabIndex = 0;
            this.btnGeneratePlan.Text = "Generate meal plan";
            this.btnGeneratePlan.UseVisualStyleBackColor = true;
            this.btnGeneratePlan.Click += new System.EventHandler(this.btnGeneratePlan_Click);
            // 
            // btnAddMeal
            // 
            this.btnAddMeal.Location = new System.Drawing.Point(310, 237);
            this.btnAddMeal.Name = "btnAddMeal";
            this.btnAddMeal.Size = new System.Drawing.Size(173, 23);
            this.btnAddMeal.TabIndex = 1;
            this.btnAddMeal.Text = "Add meal";
            this.btnAddMeal.UseVisualStyleBackColor = true;
            this.btnAddMeal.Click += new System.EventHandler(this.btnAddMeal_Click);
            // 
            // frmInitial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddMeal);
            this.Controls.Add(this.btnGeneratePlan);
            this.Name = "frmInitial";
            this.Text = "Meal Planner";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGeneratePlan;
        private System.Windows.Forms.Button btnAddMeal;
    }
}

