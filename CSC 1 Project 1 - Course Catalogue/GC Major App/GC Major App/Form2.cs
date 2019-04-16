using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

        //***************************************
        //
        //  Created by Cavan Lemasters
        //  March 6-9th 2017
        //  CSC 101 First Proj
        //
        //***************************************

namespace GC_Major_App
{
    public partial class Form2 : Form
    {


        public Form2()
        {
            InitializeComponent();
        }

        // List Box holds the example majors 
        // User needs to select a major then hit 'enter' button to display relevant course requirements        
        // 6 Majors listed are Business, Biblical Studies, Comp Sci, Criminal Justice, Engineering, Music 

        private void EnterButton_Click(object sender, EventArgs e)
        {
            // Holds the major selected out of the box 
            String Major;


            if (MajorSelectionBox.SelectedIndex != -1)
            {
                // Gets the selected item
                Major = MajorSelectionBox.SelectedItem.ToString();

                // Determines and lists the reqs for major
                switch (Major)
                {
                    case "Business": // Lists the reqs to achieve a minor in Business
                        CourseInfoBox.Text = " ACC 151 Principles of Accounting I \n ACC 256 Managerial Accounting \n BUS 110 Business Foundations \n BUS 115 Business Communication \n BUS 241 and 242 Business Analytics I and II \n BUS 310 Principles of Management \n BUS 311 Business Law \n BUS 314 International Business \n BUS 320 Principles of Marketing \n BUS 330 Principles of Finance \n BUS 344 Management of Information Systems \n BUS 350 Human Resource Management \n BUS 400 Biblical Management and Business Ethics \n BUS 410 Strategic Management \n BUS 415 Operations Management \n ECO 211 and 212 (Micro and Macro) Economics";
                        break;

                    case "Computer Science": // Lists the reqs to achieve a major in Computer Science
                        CourseInfoBox.Text = " CSC 101 Structured Programming \n CSC 102 Object-Oriented Programming \n CSC 133 Survey of Computer Science \n CSC 203 Software Engineering \n CSC 204 Algorithms \n CSC 251 Networks and Security \n CSC 311 Cyberethics \n CSC 363 Database Systems \n CSC 481 Senior Project 1 or CSC 483  Software Engineering Project 1 \n CSC 482 Senior Project 2 or CSC 484 Senior Engineering Project 2 \n MAT 130 Discrete Mathematics \n MAT 105 Elementary Statistical Methods or MAT 265 Probability and Statistics";
                        break;

                    case "Criminal Justice": // Lists the reqs to achieve a major in Criminal Justice
                        CourseInfoBox.Text = " POL 151 American Govt or POL 254 State and Local Government \n POL 360 Public Administration \n CRJ 210 Crime, Law and Society \n CRJ 215 Career Pathways in Criminal Justice \n SOC 242 Criminology \n SOC 310 Deviance and Marginalization \n PSY 313 Abnormal Psychology \n CRJ 230 Juvenile Justice \n CRJ 260 Criminal Law \n CRJ 310 Criminal Justice Systems \n CRJ 345 Probation and Parole \n CRJ 360 Criminal Investigations and Procedures \n CRJ 493 Internship in Criminal Justice \n CRJ 450 Senior Seminar and Professional Ethics \n CRJ 350 Cyberlaw \n POL 331 Foreign and National Security \n POL 342 Global Terrorism";
                        break;

                    case "Engineering": // Lists the reqs to achieve a major in Engineering
                        CourseInfoBox.Text = " MAT 161 Calculus I \n MAT 162 Calculus II \n MAT 265 Probability and Statistics \n MAT 405 Differential Equations \n CHM 111 General College Chemistry \n PHY 201 College Physics I \n ECO 270 Principles of Microeconomics for Engineers \n EGR 100 Calling and Vocation \n EGR 101 Introduction to Engineering \n EGR 102 Computer-Aided Engineering \n EGR 211 Solid Mechanics \n EGR 212 Linear Circuit Analysis I \n EGR 330 Thermal Fluid Sciences \n EGR 401 Christian Ethics and Engineering \n EGR 481 and 482 Senior Design Project";
                        break;

                    case "Music": // Lists the reqs to achieve a major in Music
                        CourseInfoBox.Text = " Detailed comprehension of the logic and context of music. \n Courses in music theory (MUS 108, MUS 109, MUS 208, MUS 209) and aural skills (MUS 128, MUS 129, MUS 228, MUS 229) provide understanding of musicianship \n Writing and composition, and analysis \n Those in music history (MUS 310, MUS 311, MUS 370) examine music’s social context \n critical writing, and style \n Introduction to Acoustics (PHY 160) studies the creational framework within which music operates \n Independent and directed study (MUS 491, MUS 495) offer additional insights.";
                        break;

                    case "Biblical Studies": // Lists the reqs to achieve a major in Biblical Studies
                        CourseInfoBox.Text = " BIB 200 How to Read the Bible \n BIB 308 Matthew OR Mark OR Luke \n BIB 304 Psalms \n PHI 113 C.S. Lewis \n PHI 100 Critical Thinking \n PHI 200 Plato \n BIB 350 History of the Christian Church \n BIB 351 Church History I:Patristic and Medieval OR BIB 352 Church History II: Reformation and Modern OR BIB 353 Covenanter History and Theology (Scotland) \n BIB 320 Special Topics in Theology \n BIB 324 Introduction to Reformed Tradition \n BIB 322 Calvin’s Institutes \n BIB 325 Biblical Theology \n MIN 210 Evangelism \n MIN 205 Christian Education in the Local Church \n MIN 215 Methods of Teaching the Bible \n MIN 219 World Christian Movement OR MIN 220 Topics in Christian Ministry";
                        break;                      
                }

            }
            else
            {
                // No Major is Selected
                MessageBox.Show(" Error: No major has been selected, please select a major!");
            }
                   
                

        }  
             
        private void CloseButton2_Click(object sender, EventArgs e)
            // Form 2 Close button designed to close application when user is finished
        {
            this.Close();
        }

         
        private void ClearButton_Click(object sender, EventArgs e)
             // Clear Button designed to remove the selected major and its reqs so user
             // can choose a new Major to get information about 
        {
            // Clears selected major for user to choose a new one
            MajorSelectionBox.SelectedIndex = -1;

            // Clears the bottom Course Reqs Box of text
            CourseInfoBox.Text = " ";

            // Pop up message 
            MessageBox.Show("Selection cleared, please choose a new one!");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Ignore this part // 
                 // Trying something new on the side to experiment with
                 // 'Back' button to return to the original window from the second window
            
            // Hides current window, opens the first window
            this.Hide();

            // Show the original window
            Form1 Form1 = new Form1();
            Form1.ShowDialog();

            //Close second window
            this.Close();
        }
    }
}
