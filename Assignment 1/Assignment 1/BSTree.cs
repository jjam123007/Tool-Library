using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    public class BSTree
    {
        private Member member; //value
        private BSTree lchild;
        private BSTree rchild;

        public BSTree(Member member) 
        {
            this.member = member;
            lchild = null;
            rchild = null;
        }
		public Member Member
		{
			get { return member; }
			set { member = value; }
		}

		public BSTree LChild
		{
			get { return lchild; }
			set { lchild = value; }
		}

		public BSTree RChild
		{
			get { return rchild; }
			set { rchild = value; }
		}
	}
}
