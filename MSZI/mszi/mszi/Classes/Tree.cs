namespace mszi.Classes
{

    public class Tree
    {
        public Tree Left { get; set; }
        public Tree Right { get; set; }
        public Item Item { get; set; }
        public Tree(int l, int c)
        {
            Item = new Item(l,c);
        }
        public Tree(Tree l, Tree r)
        {
            Left = l;
            Right = r;
            Item = new Item(0, Left.Item.Count + Right.Item.Count);
        }
        public string GetCode(int letter)
        {
            var code = Code(letter, Left);
            if (code != null)
                return "0" + (code == "2" ? null : code);
            code = Code(letter, Right);
            return code != null?"1" + (code == "2" ? null : code) : null;
        }
        public string Code(int letter, Tree tree)
        {
            if (tree == null) return null;
            if (tree.Item.Letter == letter)
                return "2";
            var code = Code(letter, tree.Left);
            if (code != null)
                return "0" + (code == "2" ? null : code);
            code = Code(letter, tree.Right);
            return code != null ? "1" + (code == "2" ? null : code) : null;
        }
        public string ViewTree(Tree top, int currentTop, int currentSheet, int level = 0, bool left = false)//Последовательный обход дерева с подсчетом вершин и листьев.
        {
                var str = "";
                if (top.Right != null) str += ViewTree(top.Right, currentTop, currentSheet, level + 1, false);
                currentTop++;
                if (top.Left == null && top.Right == null) currentSheet++;
                for (int i = 0; i < level * 2; ++i)
                    str +="   ";
                str += (top.Item.Letter>0? ((char)top.Item.Letter).ToString(): top.Item.Count.ToString()) + 
                    (level > 0 ? left ? "(0)" : "(1)" : "") + "\n";
                if (top.Left!=null) str += ViewTree(top.Left, currentTop, currentSheet, level + 1, true);
                return str;
        }      

        public string GetWord(string[] letters)
        {
            string word = "";
            foreach(var letter in letters)
                    word += letter[0] == '0'? 
                        (char)Word(letter.Substring(1), Left):
                        (char)Word(letter.Substring(1), Right);  
            return word;
        }

        public int Word(string letter, Tree tree)
        {
            if (letter.Length == 1)
                return letter[0] == '0' ? tree.Left.Item.Letter : tree.Right.Item.Letter;
            var let = letter.Length > 2 ? letter.Substring(1) : letter[1].ToString();
            return letter[0] == '0'?Word(let, tree.Left):Word(let, tree.Right);
        }
    }
}
