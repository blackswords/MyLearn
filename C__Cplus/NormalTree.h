//链树的创建
BinTree CreatBinTree()
{
	BinTree p;

	char ch;
	cin >> ch;
	
	if (ch == '0')     //如果到了叶子节点，接下来的左、右子树分别赋值为0
		p = NULL;
	else
	{
		p = (BinTree)malloc(sizeof(struct TNode));
		p->Left = p->Right = NULL;
		p->Data = 0;
		p->Data = ch;
		p->Left = CreatBinTree();  //递归创建左子树
		p->Right = CreatBinTree();  //递归创建右子树
	}
	return p;
}

// 利用中序和后序序列完成树的的建立

void Creat(int* a, int* b, int n, int Top)
{
	int i = 0;

	if (n == 0)
		return ;

	tree[Top] = a[n - 1];
	if (Top > cnNode) cnNode = Top;
	for (i = 0; i < n; i++)
	{
		if (b[i] == a[n - 1])
		{
			break;
		}
	}

	Creat(a, b, i, Top*2);
	Creat(a + i, b + i + 1, n - i - 1,Top*2+1);

	return;
}

Tree * CreatTree(int* a, int* b, int n)
{
	int i = 0;
	Tree* S=NULL;
	S =  (Tree*) malloc(sizeof(struct TreeNode));
	if (n <= 0)
		return NULL;

	S->value = a[n - 1];
	for (i = 0; i < n; i++)
	{
		if (b[i] == a[n - 1])
			break;
	}

	S->lchild = CreatTree(a, b, i);
	S->rchile = CreatTree(a + i, b + i + 1, n - i - 1);

	return S;
}
//结束
void InorderTraversal(BinTree BT)
{
	if (BT)
	{
		InorderTraversal(BT->Left);
		printf(" %c", BT->Data);
		InorderTraversal(BT->Right);
	}
}

void PreorderTraversal(BinTree BT)
{
	if (BT)
	{
		printf(" %c", BT->Data);
		InorderTraversal(BT->Left);
		InorderTraversal(BT->Right);
	}
}

void PostorderTraversal(BinTree BT)
{
	if (BT)
	{
		InorderTraversal(BT->Left);
		InorderTraversal(BT->Right);
		printf(" %c", BT->Data);
	}
}

void LevelorderTraversal(BinTree BT)
{
	BinTree q[1001], p;
	int front, rear;
	front = rear = -1;
	q[++rear] = BT;
	while (front != rear)
	{
		p = q[++front];
		if (p->Left) q[++rear] = p->Left;
		if (p->Right) q[++rear] = p->Right;
		printf(" %c", p->Data);
	}
}
