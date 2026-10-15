using Trees;

Tree<Person> company = new Tree<Person>();

company.Root = new TreeNode<Person> ()
{
    Data = new Person(100, "Marcin Jamro", "CEO"),
    Parent = null
};


