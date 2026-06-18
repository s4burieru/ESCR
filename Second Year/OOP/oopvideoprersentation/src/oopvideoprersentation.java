    
 import javax.swing.*;
 import java.awt.*;
 import java.awt.event.ActionEvent;
 import java.awt.event.ActionListener;
 
public class oopvideoprersentation {
    
    public static void main(String[] args) {
    	
    	JFrame frame = new JFrame("Personal Details");
    	frame.setSize(400,230);
    	frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    	frame.setLayout(new FlowLayout());
    	frame.setLocationRelativeTo(null);
    	frame.setVisible(true);
    	
		JButton namebutton = new JButton("NAME");
		JButton agebutton = new JButton("AGE");
		JButton genderbutton = new JButton("GENDER");
		JButton addressbutton = new JButton("ADDRESS");
		JButton contactbutton = new JButton("CONTACT NO.");
		
		final JTextField firstnametextbox = new JTextField(30);
		final JTextField lastnametextbox = new JTextField(40);
		final JTextField agetextbox = new JTextField(10);
		final JTextField gendertextbox = new JTextField(10);
		final JTextField addresstextbox = new JTextField(30);
		final JTextField address2textbox = new JTextField(40);
		final JTextField contacttextbox = new JTextField(28);
		
		frame.add(namebutton);
		frame.add(firstnametextbox);
		frame.add(lastnametextbox);
		frame.add(agebutton);
		frame.add(agetextbox);
		frame.add(genderbutton);
		frame.add(gendertextbox);
		frame.add(addressbutton);
		frame.add(addresstextbox);
		frame.add(address2textbox);
		frame.add(contactbutton);
		frame.add(contacttextbox);
		
		namebutton.addActionListener(new ActionListener()
		{
			@Override
			public void actionPerformed(ActionEvent e){
				firstnametextbox.setText("Sabriel Adriel");
				lastnametextbox.setText("San Agustin");
			}
		});
		
		
		agebutton.addActionListener(new ActionListener()
		{
			@Override
			public void actionPerformed(ActionEvent e){
				agetextbox.setText("20");
			}
		});
		
		
		genderbutton.addActionListener(new ActionListener()
		{
			@Override
			public void actionPerformed(ActionEvent e){
				gendertextbox.setText("Male");
			}
		});
		
		
		addressbutton.addActionListener(new ActionListener()
		{
			@Override
			public void actionPerformed(ActionEvent e){
				addresstextbox.setText("55 G. Trinidad St.");
				address2textbox.setText("Brgy. Wawa, Tanay, Rizal");
			}
		});
		
		
		contactbutton.addActionListener(new ActionListener()
		{
			@Override
			public void actionPerformed(ActionEvent e){
				contacttextbox.setText("09502458088");
			}
		});
		
    }
}
