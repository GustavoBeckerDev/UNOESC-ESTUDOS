using Trees;

// ATRIBUIÇÃO INLINE

Tree<int> tree = new Tree<int>();

tree.Root = new TreeNode<int>()
{
    Data = 100 
};

// CRIANDO OS FILHOS DE ROOT

tree.Root.Children = new List<TreeNode<int>>
{
    new TreeNode<int>() { Data = 50, Parent = tree.Root},
    new TreeNode<int>() { Data = 1, Parent = tree.Root},
    new TreeNode<int>() { Data = 150, Parent = tree.Root}
};

// ACESSANDO E CRIANDO OS CHILDRENS DOS CHILDRENS

// ACESSANDO 50 E CRIANDO O/OS FILHOS
tree.Root.Children[0].Children = new List<TreeNode<int>>()
{
    new TreeNode<int>() { Data = 12, Parent = tree.Root.Children[0] }
};

    // AQUI É O 12
    tree.Root.Children[0].Children[0].Children = new List<TreeNode<int>>()
    {
        new TreeNode<int>() { Data = 45, Parent = tree.Root.Children[0].Children[0] },// AQUI É O 45
        new TreeNode<int>() { Data = 21, Parent = tree.Root.Children[0].Children[0] },// AQUI É O 21
    };

        // AQUI É O 6
        tree.Root.Children[0].Children[0].Children[1].Children = new List<TreeNode<int>>()
        {
            new TreeNode<int>() { Data = 6, Parent = tree.Root.Children[0].Children[0].Children[1] }
        };

// AQUI É O NÚMERO 1 E O/OS FILHOS
tree.Root.Children[1].Children = new List<TreeNode<int>>()
{
    new TreeNode<int>() { Data = 70, Parent = tree.Root.Children[1] },
    new TreeNode<int>() { Data = 61, Parent = tree.Root.Children[1] }
};


// AQUI É O/OS FILHOS DE 150

tree.Root.Children[2].Children = new List<TreeNode<int>>()
{
    new TreeNode<int>() { Data = 30, Parent = tree.Root.Children[2] },
    new TreeNode<int>() { Data = 5, Parent = tree.Root.Children[2] },
    new TreeNode<int>() { Data = 11, Parent = tree.Root.Children[2] },
};

tree.Root.Children[2].Children[0].Children = new List<TreeNode<int>>()
{
    new TreeNode<int>() { Data = 96, Parent = tree.Root.Children[2].Children[0] },
    new TreeNode<int>() { Data = 9, Parent = tree.Root.Children[2].Children[0] }
};