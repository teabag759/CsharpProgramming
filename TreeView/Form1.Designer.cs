namespace TreeView
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode67 = new System.Windows.Forms.TreeNode("MFC 시스템 프로그래밍");
            System.Windows.Forms.TreeNode treeNode68 = new System.Windows.Forms.TreeNode("Win32 기반의 API 프로그래밍");
            System.Windows.Forms.TreeNode treeNode69 = new System.Windows.Forms.TreeNode("C++ 프로그래밍과 STL");
            System.Windows.Forms.TreeNode treeNode70 = new System.Windows.Forms.TreeNode("C언어의 정석");
            System.Windows.Forms.TreeNode treeNode71 = new System.Windows.Forms.TreeNode("프로그래밍 언어", new System.Windows.Forms.TreeNode[] {
            treeNode67,
            treeNode68,
            treeNode69,
            treeNode70});
            System.Windows.Forms.TreeNode treeNode72 = new System.Windows.Forms.TreeNode("안드로이드 프로그래밍");
            System.Windows.Forms.TreeNode treeNode73 = new System.Windows.Forms.TreeNode("내 생애 첫번째 코딩 앱인벤터");
            System.Windows.Forms.TreeNode treeNode74 = new System.Windows.Forms.TreeNode("모바일 프로그래밍", new System.Windows.Forms.TreeNode[] {
            treeNode72,
            treeNode73});
            System.Windows.Forms.TreeNode treeNode75 = new System.Windows.Forms.TreeNode("데이터베이스");
            System.Windows.Forms.TreeNode treeNode76 = new System.Windows.Forms.TreeNode("네트워크");
            System.Windows.Forms.TreeNode treeNode77 = new System.Windows.Forms.TreeNode("IT도서", new System.Windows.Forms.TreeNode[] {
            treeNode71,
            treeNode74,
            treeNode75,
            treeNode76});
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tbNode = new System.Windows.Forms.TextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExpandAll = new System.Windows.Forms.Button();
            this.btnCollapseAll = new System.Windows.Forms.Button();
            this.btnChkDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNode
            // 
            this.tbNode.Location = new System.Drawing.Point(329, 12);
            this.tbNode.Name = "tbNode";
            this.tbNode.Size = new System.Drawing.Size(157, 21);
            this.tbNode.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.CheckBoxes = true;
            this.treeView1.Location = new System.Drawing.Point(22, 12);
            this.treeView1.Name = "treeView1";
            treeNode67.Name = "노드3";
            treeNode67.Text = "MFC 시스템 프로그래밍";
            treeNode68.Name = "노드5";
            treeNode68.Text = "Win32 기반의 API 프로그래밍";
            treeNode69.Name = "노드6";
            treeNode69.Text = "C++ 프로그래밍과 STL";
            treeNode70.Name = "노드7";
            treeNode70.Text = "C언어의 정석";
            treeNode71.Name = "노드1";
            treeNode71.Text = "프로그래밍 언어";
            treeNode72.Name = "노드8";
            treeNode72.Text = "안드로이드 프로그래밍";
            treeNode73.Name = "노드9";
            treeNode73.Text = "내 생애 첫번째 코딩 앱인벤터";
            treeNode74.Name = "노드2";
            treeNode74.Text = "모바일 프로그래밍";
            treeNode75.Name = "노드10";
            treeNode75.Text = "데이터베이스";
            treeNode76.Name = "노드11";
            treeNode76.Text = "네트워크";
            treeNode77.Name = "Root";
            treeNode77.Text = "IT도서";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode77});
            this.treeView1.Size = new System.Drawing.Size(279, 426);
            this.treeView1.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(329, 39);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(157, 40);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "추가";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(329, 102);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(157, 44);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExpandAll
            // 
            this.btnExpandAll.Location = new System.Drawing.Point(329, 168);
            this.btnExpandAll.Name = "btnExpandAll";
            this.btnExpandAll.Size = new System.Drawing.Size(157, 43);
            this.btnExpandAll.TabIndex = 4;
            this.btnExpandAll.Text = "확장";
            this.btnExpandAll.UseVisualStyleBackColor = true;
            this.btnExpandAll.Click += new System.EventHandler(this.btnExpandAll_Click);
            // 
            // btnCollapseAll
            // 
            this.btnCollapseAll.Location = new System.Drawing.Point(329, 234);
            this.btnCollapseAll.Name = "btnCollapseAll";
            this.btnCollapseAll.Size = new System.Drawing.Size(157, 43);
            this.btnCollapseAll.TabIndex = 5;
            this.btnCollapseAll.Text = "축소";
            this.btnCollapseAll.UseVisualStyleBackColor = true;
            this.btnCollapseAll.Click += new System.EventHandler(this.btnCollapseAll_Click);
            // 
            // btnChkDelete
            // 
            this.btnChkDelete.Location = new System.Drawing.Point(329, 298);
            this.btnChkDelete.Name = "btnChkDelete";
            this.btnChkDelete.Size = new System.Drawing.Size(157, 43);
            this.btnChkDelete.TabIndex = 6;
            this.btnChkDelete.Text = "체크된 것만 삭제";
            this.btnChkDelete.UseVisualStyleBackColor = true;
            this.btnChkDelete.Click += new System.EventHandler(this.btnChkDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 450);
            this.Controls.Add(this.btnChkDelete);
            this.Controls.Add(this.btnCollapseAll);
            this.Controls.Add(this.btnExpandAll);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.tbNode);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox tbNode;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExpandAll;
        private System.Windows.Forms.Button btnCollapseAll;
        private System.Windows.Forms.Button btnChkDelete;
    }
}

