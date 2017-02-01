package jnewpack;
import java.awt.Container;
import javax.swing.JFrame;
import javax.swing.JScrollPane;
import javax.swing.JTree;
import javax.swing.tree.DefaultMutableTreeNode;

public class SimpleTree extends JFrame{
    public SimpleTree(){
        setTitle("Tree");
        setSize(300, 250);
        
        DefaultMutableTreeNode root = new DefaultMutableTreeNode("Кыргызстан");
        DefaultMutableTreeNode region = new DefaultMutableTreeNode("Чуйская область");
        root.add(region);
        DefaultMutableTreeNode city = new DefaultMutableTreeNode("Бишкек");
        region.add(city);
        city = new DefaultMutableTreeNode("Кара-Балта");
        region.add(city);
        city = new DefaultMutableTreeNode("Каинда");
        region.add(city);
        city = new DefaultMutableTreeNode("Токмок");
        region.add(city);
        
        region = new DefaultMutableTreeNode("Иссык-Кульская область");
        root.add(region);
        city = new DefaultMutableTreeNode("Балыкчы");
        region.add(city);
        city = new DefaultMutableTreeNode("Каракол");
        region.add(city);
        city = new DefaultMutableTreeNode("Чолпон-Ата");
        region.add(city);
        
        region = new DefaultMutableTreeNode("Ошская область");
        root.add(region);
        city = new DefaultMutableTreeNode("Ош");
        region.add(city);
        city = new DefaultMutableTreeNode("Кызыл-кия");
        region.add(city);
        
        JTree tree = new JTree(root);
        Container contentPane = getContentPane();
        contentPane.add(new JScrollPane(tree));
    }
}