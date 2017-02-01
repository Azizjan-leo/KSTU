package jnewpack;
import java.awt.BorderLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JScrollPane;
import javax.swing.JTable;
import javax.swing.RowSorter;
import javax.swing.table.DefaultTableModel;
import javax.swing.table.TableModel;
import javax.swing.table.TableRowSorter;


class SimpleTable extends JFrame{
    public SimpleTable(){
        setTitle("Группа ПИ 1-14");
        setSize(400, 400);
        
        //add(new JScrollPane(table), BorderLayout.CENTER);
        //JButton printButton = new JButton("Print");
        /*printButton.addActionListener( new ActionListener() {

            @Override
            public void actionPerformed(ActionEvent e) {
                try
                {
                    table.print();
                }
                catch(java.awt.print.PrinterException ex){
                    ex.printStackTrace();
                }
            }
        });*/
        
        TableModel model = new DefaultTableModel(cells, columnNames) {
        public Class getColumnClass(int column) {
          Class returnValue;
          if ((column >= 0) && (column < getColumnCount())) {
            returnValue = getValueAt(0, column).getClass();
          } else {
            returnValue = Object.class;
          }
          return returnValue;
          }
        };
        
        //final JTable table = new JTable (cells, columnNames);
        JTable table = new JTable(model);
        add(new JScrollPane(table), BorderLayout.CENTER);
        
        RowSorter<TableModel> sorter = new TableRowSorter<TableModel>(model);
        table.setRowSorter(sorter);
    }
    
    private Object[][] cells = {
        {"Седокина Алина", "ж", 1997},
        {"Браташова Дарья", "ж", 1996},
        {"Жарков Руслан", "м", 1997}
    };
    private String[] columnNames = {"ФИО", "Пол", "Дата рождения"};
}