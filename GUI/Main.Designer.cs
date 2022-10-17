using System;

namespace GUI
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pbMaze = new System.Windows.Forms.PictureBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.lblDijkstra = new System.Windows.Forms.Label();
            this.lblAStar = new System.Windows.Forms.Label();
            this.lblBFS = new System.Windows.Forms.Label();
            this.lblDFS = new System.Windows.Forms.Label();
            this.btnMaze = new System.Windows.Forms.Button();
            this.lblNrOperatii = new System.Windows.Forms.Label();
            this.lblAlgoritm = new System.Windows.Forms.Label();
            this.lblUnexplored = new System.Windows.Forms.Label();
            this.lblOpen = new System.Windows.Forms.Label();
            this.lblInchis = new System.Windows.Forms.Label();
            this.lblPathLength = new System.Windows.Forms.Label();
            this.lblDijkstraOp = new System.Windows.Forms.Label();
            this.lblDijkstraNE = new System.Windows.Forms.Label();
            this.lblDijkstraOpen = new System.Windows.Forms.Label();
            this.lblDijkstraInchis = new System.Windows.Forms.Label();
            this.lblDijkstraLung = new System.Windows.Forms.Label();
            this.lblAStarLung = new System.Windows.Forms.Label();
            this.lblAStarInchis = new System.Windows.Forms.Label();
            this.lblAStarOpen = new System.Windows.Forms.Label();
            this.lblAStarNE = new System.Windows.Forms.Label();
            this.lblAStarOp = new System.Windows.Forms.Label();
            this.lblBfsLung = new System.Windows.Forms.Label();
            this.lblBreadthFirstInchis = new System.Windows.Forms.Label();
            this.lblBreadthFirstOpen = new System.Windows.Forms.Label();
            this.lblBfsNE = new System.Windows.Forms.Label();
            this.lblBfsOp = new System.Windows.Forms.Label();
            this.lblDfsLung = new System.Windows.Forms.Label();
            this.lblDepthFirstInchis = new System.Windows.Forms.Label();
            this.lblDepthFirstOpen = new System.Windows.Forms.Label();
            this.lblDfsNE = new System.Windows.Forms.Label();
            this.lblDfsOp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaze)).BeginInit();
            this.SuspendLayout();
            // 
            // pbMaze
            // 
            this.pbMaze.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMaze.Location = new System.Drawing.Point(6, 46);
            this.pbMaze.Margin = new System.Windows.Forms.Padding(2);
            this.pbMaze.Name = "pbMaze";
            this.pbMaze.Size = new System.Drawing.Size(889, 431);
            this.pbMaze.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMaze.TabIndex = 0;
            this.pbMaze.TabStop = false;
            // 
            // btnGo
            // 
            this.btnGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGo.Location = new System.Drawing.Point(86, 610);
            this.btnGo.Margin = new System.Windows.Forms.Padding(2);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(55, 24);
            this.btnGo.TabIndex = 31;
            this.btnGo.Text = "Start";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.BtnGo_Click);
            // 
            // lblDijkstra
            // 
            this.lblDijkstra.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDijkstra.Location = new System.Drawing.Point(12, 503);
            this.lblDijkstra.Name = "lblDijkstra";
            this.lblDijkstra.Size = new System.Drawing.Size(174, 24);
            this.lblDijkstra.TabIndex = 6;
            this.lblDijkstra.Text = "Dijkstra:";
            this.lblDijkstra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAStar
            // 
            this.lblAStar.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAStar.Location = new System.Drawing.Point(12, 527);
            this.lblAStar.Name = "lblAStar";
            this.lblAStar.Size = new System.Drawing.Size(174, 24);
            this.lblAStar.TabIndex = 12;
            this.lblAStar.Text = "A*:";
            this.lblAStar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBFS
            // 
            this.lblBFS.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBFS.Location = new System.Drawing.Point(8, 551);
            this.lblBFS.Name = "lblBFS";
            this.lblBFS.Size = new System.Drawing.Size(178, 24);
            this.lblBFS.TabIndex = 18;
            this.lblBFS.Text = "BFS";
            this.lblBFS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDFS
            // 
            this.lblDFS.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDFS.Location = new System.Drawing.Point(12, 575);
            this.lblDFS.Name = "lblDFS";
            this.lblDFS.Size = new System.Drawing.Size(174, 24);
            this.lblDFS.TabIndex = 24;
            this.lblDFS.Text = "DFS";
            this.lblDFS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnMaze
            // 
            this.btnMaze.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMaze.Location = new System.Drawing.Point(6, 610);
            this.btnMaze.Name = "btnMaze";
            this.btnMaze.Size = new System.Drawing.Size(75, 24);
            this.btnMaze.TabIndex = 30;
            this.btnMaze.Text = "Generare";
            this.btnMaze.UseVisualStyleBackColor = true;
            this.btnMaze.Click += new System.EventHandler(this.BtnMaze_Click);
            // 
            // lblNrOperatii
            // 
            this.lblNrOperatii.AutoSize = true;
            this.lblNrOperatii.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNrOperatii.Location = new System.Drawing.Point(182, 479);
            this.lblNrOperatii.Name = "lblNrOperatii";
            this.lblNrOperatii.Size = new System.Drawing.Size(106, 24);
            this.lblNrOperatii.TabIndex = 1;
            this.lblNrOperatii.Text = "Operatii";
            // 
            // lblAlgoritm
            // 
            this.lblAlgoritm.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlgoritm.Location = new System.Drawing.Point(269, 9);
            this.lblAlgoritm.Name = "lblAlgoritm";
            this.lblAlgoritm.Size = new System.Drawing.Size(319, 24);
            this.lblAlgoritm.TabIndex = 0;
            this.lblAlgoritm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUnexplored
            // 
            this.lblUnexplored.AutoSize = true;
            this.lblUnexplored.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnexplored.Location = new System.Drawing.Point(322, 479);
            this.lblUnexplored.Name = "lblUnexplored";
            this.lblUnexplored.Size = new System.Drawing.Size(142, 24);
            this.lblUnexplored.TabIndex = 2;
            this.lblUnexplored.Text = "Neexplorate";
            // 
            // lblOpen
            // 
            this.lblOpen.AutoSize = true;
            this.lblOpen.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpen.Location = new System.Drawing.Point(490, 479);
            this.lblOpen.Name = "lblOpen";
            this.lblOpen.Size = new System.Drawing.Size(82, 24);
            this.lblOpen.TabIndex = 3;
            this.lblOpen.Text = "Libere";
            // 
            // lblInchis
            // 
            this.lblInchis.AutoSize = true;
            this.lblInchis.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInchis.Location = new System.Drawing.Point(577, 479);
            this.lblInchis.Name = "lblInchis";
            this.lblInchis.Size = new System.Drawing.Size(82, 24);
            this.lblInchis.TabIndex = 4;
            this.lblInchis.Text = "Ziduri";
            // 
            // lblPathLength
            // 
            this.lblPathLength.AutoSize = true;
            this.lblPathLength.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPathLength.Location = new System.Drawing.Point(688, 479);
            this.lblPathLength.Name = "lblPathLength";
            this.lblPathLength.Size = new System.Drawing.Size(190, 24);
            this.lblPathLength.TabIndex = 5;
            this.lblPathLength.Text = "Lungimea/Costul";
            // 
            // lblDijkstraOp
            // 
            this.lblDijkstraOp.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDijkstraOp.Location = new System.Drawing.Point(182, 503);
            this.lblDijkstraOp.Name = "lblDijkstraOp";
            this.lblDijkstraOp.Size = new System.Drawing.Size(130, 24);
            this.lblDijkstraOp.TabIndex = 7;
            this.lblDijkstraOp.Text = "0";
            this.lblDijkstraOp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDijkstraNE
            // 
            this.lblDijkstraNE.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDijkstraNE.Location = new System.Drawing.Point(322, 503);
            this.lblDijkstraNE.Name = "lblDijkstraNE";
            this.lblDijkstraNE.Size = new System.Drawing.Size(130, 24);
            this.lblDijkstraNE.TabIndex = 8;
            this.lblDijkstraNE.Text = "0";
            this.lblDijkstraNE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDijkstraOpen
            // 
            this.lblDijkstraOpen.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDijkstraOpen.Location = new System.Drawing.Point(477, 503);
            this.lblDijkstraOpen.Name = "lblDijkstraOpen";
            this.lblDijkstraOpen.Size = new System.Drawing.Size(84, 24);
            this.lblDijkstraOpen.TabIndex = 9;
            this.lblDijkstraOpen.Text = "0";
            this.lblDijkstraOpen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDijkstraInchis
            // 
            this.lblDijkstraInchis.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDijkstraInchis.Location = new System.Drawing.Point(581, 503);
            this.lblDijkstraInchis.Name = "lblDijkstraInchis";
            this.lblDijkstraInchis.Size = new System.Drawing.Size(78, 24);
            this.lblDijkstraInchis.TabIndex = 10;
            this.lblDijkstraInchis.Text = "0";
            this.lblDijkstraInchis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDijkstraLung
            // 
            this.lblDijkstraLung.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDijkstraLung.Location = new System.Drawing.Point(717, 503);
            this.lblDijkstraLung.Name = "lblDijkstraLung";
            this.lblDijkstraLung.Size = new System.Drawing.Size(133, 24);
            this.lblDijkstraLung.TabIndex = 11;
            this.lblDijkstraLung.Text = "?/?";
            this.lblDijkstraLung.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAStarLung
            // 
            this.lblAStarLung.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAStarLung.Location = new System.Drawing.Point(717, 527);
            this.lblAStarLung.Name = "lblAStarLung";
            this.lblAStarLung.Size = new System.Drawing.Size(133, 24);
            this.lblAStarLung.TabIndex = 17;
            this.lblAStarLung.Text = "?/?";
            this.lblAStarLung.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAStarInchis
            // 
            this.lblAStarInchis.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAStarInchis.Location = new System.Drawing.Point(581, 527);
            this.lblAStarInchis.Name = "lblAStarInchis";
            this.lblAStarInchis.Size = new System.Drawing.Size(78, 24);
            this.lblAStarInchis.TabIndex = 16;
            this.lblAStarInchis.Text = "0";
            this.lblAStarInchis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAStarOpen
            // 
            this.lblAStarOpen.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAStarOpen.Location = new System.Drawing.Point(477, 527);
            this.lblAStarOpen.Name = "lblAStarOpen";
            this.lblAStarOpen.Size = new System.Drawing.Size(84, 24);
            this.lblAStarOpen.TabIndex = 15;
            this.lblAStarOpen.Text = "0";
            this.lblAStarOpen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAStarNE
            // 
            this.lblAStarNE.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAStarNE.Location = new System.Drawing.Point(322, 527);
            this.lblAStarNE.Name = "lblAStarNE";
            this.lblAStarNE.Size = new System.Drawing.Size(130, 24);
            this.lblAStarNE.TabIndex = 14;
            this.lblAStarNE.Text = "0";
            this.lblAStarNE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAStarOp
            // 
            this.lblAStarOp.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAStarOp.Location = new System.Drawing.Point(182, 527);
            this.lblAStarOp.Name = "lblAStarOp";
            this.lblAStarOp.Size = new System.Drawing.Size(130, 24);
            this.lblAStarOp.TabIndex = 13;
            this.lblAStarOp.Text = "0";
            this.lblAStarOp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBfsLung
            // 
            this.lblBfsLung.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBfsLung.Location = new System.Drawing.Point(717, 551);
            this.lblBfsLung.Name = "lblBfsLung";
            this.lblBfsLung.Size = new System.Drawing.Size(133, 24);
            this.lblBfsLung.TabIndex = 23;
            this.lblBfsLung.Text = "?/?";
            this.lblBfsLung.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBreadthFirstInchis
            // 
            this.lblBreadthFirstInchis.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBreadthFirstInchis.Location = new System.Drawing.Point(581, 551);
            this.lblBreadthFirstInchis.Name = "lblBreadthFirstInchis";
            this.lblBreadthFirstInchis.Size = new System.Drawing.Size(78, 24);
            this.lblBreadthFirstInchis.TabIndex = 22;
            this.lblBreadthFirstInchis.Text = "0";
            this.lblBreadthFirstInchis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBreadthFirstOpen
            // 
            this.lblBreadthFirstOpen.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBreadthFirstOpen.Location = new System.Drawing.Point(477, 551);
            this.lblBreadthFirstOpen.Name = "lblBreadthFirstOpen";
            this.lblBreadthFirstOpen.Size = new System.Drawing.Size(84, 24);
            this.lblBreadthFirstOpen.TabIndex = 21;
            this.lblBreadthFirstOpen.Text = "0";
            this.lblBreadthFirstOpen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBfsNE
            // 
            this.lblBfsNE.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBfsNE.Location = new System.Drawing.Point(322, 551);
            this.lblBfsNE.Name = "lblBfsNE";
            this.lblBfsNE.Size = new System.Drawing.Size(130, 24);
            this.lblBfsNE.TabIndex = 20;
            this.lblBfsNE.Text = "0";
            this.lblBfsNE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBfsOp
            // 
            this.lblBfsOp.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBfsOp.Location = new System.Drawing.Point(182, 551);
            this.lblBfsOp.Name = "lblBfsOp";
            this.lblBfsOp.Size = new System.Drawing.Size(130, 24);
            this.lblBfsOp.TabIndex = 19;
            this.lblBfsOp.Text = "0";
            this.lblBfsOp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDfsLung
            // 
            this.lblDfsLung.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDfsLung.Location = new System.Drawing.Point(717, 575);
            this.lblDfsLung.Name = "lblDfsLung";
            this.lblDfsLung.Size = new System.Drawing.Size(133, 24);
            this.lblDfsLung.TabIndex = 29;
            this.lblDfsLung.Text = "?/?";
            this.lblDfsLung.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDepthFirstInchis
            // 
            this.lblDepthFirstInchis.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepthFirstInchis.Location = new System.Drawing.Point(581, 575);
            this.lblDepthFirstInchis.Name = "lblDepthFirstInchis";
            this.lblDepthFirstInchis.Size = new System.Drawing.Size(78, 24);
            this.lblDepthFirstInchis.TabIndex = 28;
            this.lblDepthFirstInchis.Text = "0";
            this.lblDepthFirstInchis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDepthFirstOpen
            // 
            this.lblDepthFirstOpen.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepthFirstOpen.Location = new System.Drawing.Point(477, 575);
            this.lblDepthFirstOpen.Name = "lblDepthFirstOpen";
            this.lblDepthFirstOpen.Size = new System.Drawing.Size(84, 24);
            this.lblDepthFirstOpen.TabIndex = 27;
            this.lblDepthFirstOpen.Text = "0";
            this.lblDepthFirstOpen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDfsNE
            // 
            this.lblDfsNE.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDfsNE.Location = new System.Drawing.Point(322, 575);
            this.lblDfsNE.Name = "lblDfsNE";
            this.lblDfsNE.Size = new System.Drawing.Size(130, 24);
            this.lblDfsNE.TabIndex = 26;
            this.lblDfsNE.Text = "0";
            this.lblDfsNE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDfsOp
            // 
            this.lblDfsOp.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDfsOp.Location = new System.Drawing.Point(182, 575);
            this.lblDfsOp.Name = "lblDfsOp";
            this.lblDfsOp.Size = new System.Drawing.Size(130, 24);
            this.lblDfsOp.TabIndex = 25;
            this.lblDfsOp.Text = "0";
            this.lblDfsOp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(902, 645);
            this.Controls.Add(this.lblDfsLung);
            this.Controls.Add(this.lblDepthFirstInchis);
            this.Controls.Add(this.lblDepthFirstOpen);
            this.Controls.Add(this.lblDfsNE);
            this.Controls.Add(this.lblDfsOp);
            this.Controls.Add(this.lblBfsLung);
            this.Controls.Add(this.lblBreadthFirstInchis);
            this.Controls.Add(this.lblBreadthFirstOpen);
            this.Controls.Add(this.lblBfsNE);
            this.Controls.Add(this.lblBfsOp);
            this.Controls.Add(this.lblAStarLung);
            this.Controls.Add(this.lblAStarInchis);
            this.Controls.Add(this.lblAStarOpen);
            this.Controls.Add(this.lblAStarNE);
            this.Controls.Add(this.lblAStarOp);
            this.Controls.Add(this.lblDijkstraLung);
            this.Controls.Add(this.lblDijkstraInchis);
            this.Controls.Add(this.lblDijkstraOpen);
            this.Controls.Add(this.lblDijkstraNE);
            this.Controls.Add(this.lblDijkstraOp);
            this.Controls.Add(this.lblPathLength);
            this.Controls.Add(this.lblInchis);
            this.Controls.Add(this.lblOpen);
            this.Controls.Add(this.lblUnexplored);
            this.Controls.Add(this.lblAlgoritm);
            this.Controls.Add(this.lblNrOperatii);
            this.Controls.Add(this.btnMaze);
            this.Controls.Add(this.lblDFS);
            this.Controls.Add(this.lblBFS);
            this.Controls.Add(this.lblAStar);
            this.Controls.Add(this.lblDijkstra);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.pbMaze);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main";
            this.Text = "Path Finding";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbMaze)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.PictureBox pbMaze;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label lblDijkstra;
        private System.Windows.Forms.Label lblAStar;
        private System.Windows.Forms.Label lblBFS;
        private System.Windows.Forms.Label lblDFS;
        private System.Windows.Forms.Button btnMaze;
        private System.Windows.Forms.Label lblNrOperatii;
        private System.Windows.Forms.Label lblAlgoritm;
        private System.Windows.Forms.Label lblUnexplored;
        private System.Windows.Forms.Label lblOpen;
        private System.Windows.Forms.Label lblInchis;
        private System.Windows.Forms.Label lblPathLength;
        private System.Windows.Forms.Label lblDijkstraOp;
        private System.Windows.Forms.Label lblDijkstraNE;
        private System.Windows.Forms.Label lblDijkstraOpen;
        private System.Windows.Forms.Label lblDijkstraInchis;
        private System.Windows.Forms.Label lblDijkstraLung;
        private System.Windows.Forms.Label lblAStarLung;
        private System.Windows.Forms.Label lblAStarInchis;
        private System.Windows.Forms.Label lblAStarOpen;
        private System.Windows.Forms.Label lblAStarNE;
        private System.Windows.Forms.Label lblAStarOp;
        private System.Windows.Forms.Label lblBfsLung;
        private System.Windows.Forms.Label lblBreadthFirstInchis;
        private System.Windows.Forms.Label lblBreadthFirstOpen;
        private System.Windows.Forms.Label lblBfsNE;
        private System.Windows.Forms.Label lblBfsOp;
        private System.Windows.Forms.Label lblDfsLung;
        private System.Windows.Forms.Label lblDepthFirstInchis;
        private System.Windows.Forms.Label lblDepthFirstOpen;
        private System.Windows.Forms.Label lblDfsNE;
        private System.Windows.Forms.Label lblDfsOp;
    }
}

