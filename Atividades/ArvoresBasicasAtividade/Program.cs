using ArvoresBasicasAtividade;


Tree<string> tree = new Tree<string>();
tree.Root = new Node<string>() { Data = "Marcin Jamro" };
tree.Root.Children = 
    new List<Node<string>>{
        new Node<string>() { Data = "John Smith", Parent = tree.Root },
        new Node<string>() { Data = "Mary Fox", Parent = tree.Root },
        new Node<string>() { Data = "Lily Smith", Parent= tree.Root },
    };
Node<string> node12 = new Node<string>() { Data = "Chris Morris", Parent = tree.Root.Children[0]};
Node<string> node45 = new Node<string>() { Data = "Eric Green", Parent = node12};
Node<string> node21 = new Node<string>() { Data = "Emily Young", Parent = node12};

node12.Children!.Add(node45);
node12.Children!.Add(node21);

tree.Root.Children[0].Children!.Add(node12);

tree.PrintTree(tree.Root);