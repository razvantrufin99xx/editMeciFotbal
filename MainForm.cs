/*
 * Created by SharpDevelop.
 * User: razvan
 * Date: 9/4/2024
 * Time: 1:01 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace editorMeci
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void MainFormLoad(object sender, EventArgs e)
		{
	
		}
		void Button1Click(object sender, EventArgs e)
		{
			
			this.label16.Text = "";
			string sxmlhead =   "<?xml version='1.0' encoding='UTF-8'?>";
			 string sxml = sxmlhead + "<meci>" +"\r\n";
			 sxml+= "<echipagazda>"+this.textBox1.Text+"</echipagazda>"+"\r\n";
			 sxml+= " <scorfinal>"+"\r\n";
			 sxml+= " <golgazda>"+this.textBox3.Text+"</golgazda>"+"\r\n";
			 sxml+= " <goloaspete>"+this.textBox4.Text+"</goloaspete>"+"\r\n";
			 sxml+= " </scorfinal>"+"\r\n";
			 sxml+= " <scorpauza>"+"\r\n";
			 sxml+= " <golgazda>"+this.textBox6.Text+"</golgazda>"+"\r\n";
			 sxml+= " <goloaspete>"+this.textBox5.Text+"</goloaspete>"+"\r\n";
			 sxml+= " </scorpauza>"+"\r\n";
			 sxml+= " <echipaoaspete>"+this.textBox2.Text+"</echipaoaspete>"+"\r\n";
			 sxml+= " <scorprelungiri>"+"\r\n";
			 sxml+= " <golgazda>"+this.textBox10.Text+"</golgazda>"+"\r\n";
			 sxml+= " <goloaspete>"+this.textBox9.Text+"</goloaspete>"+"\r\n";
			 sxml+= " </scorprelungiri>"+"\r\n";
	         sxml+= " <scorpenaltiuri>"+"\r\n";
			 sxml+= " <golgazda>"+this.textBox8.Text+"</golgazda>"+"\r\n";
			 sxml+= " <goloaspete>"+this.textBox7.Text+"</goloaspete>"+"\r\n";
			 sxml+= " </scorpenaltiuri>"+"\r\n";
			 sxml+= " <stadion>"+this.textBox11.Text+"</stadion>"+"\r\n";
			 sxml+= "<oras>"+this.textBox12.Text+"</oras>"+"\r\n";
			 sxml+= "<competitia>"+this.textBox13.Text+"</competitia>"+"\r\n";
			 sxml+= " <orasidatastart>"+this.textBox14.Text+"</orasidatastart>"+"\r\n";
     		 sxml+= " <nrspectatori>"+this.textBox15.Text+"</nrspectatori>"+"\r\n";
			 sxml+= " <tara>"+this.textBox16.Text+"</tara>"+"\r\n";
			 sxml+= " <transmisdepostul>"+this.textBox17.Text+"</transmisdepostul>"+"\r\n";
			 sxml+= " <orasidatafinal>"+this.textBox18.Text+"</orasidatafinal>"+"\r\n";
	         sxml+= "</meci>"+"\r\n";
			 /*
			  <?xml version="1.0" encoding="UTF-8"?>
<meci>
<echipagazda>sibiu</echipagazda>
 <scorfinal>
 <golgazda>6</golgazda>
 <goloaspete>2</goloaspete>
 </scorfinal>
 <scorpauza>
 <golgazda>4</golgazda>
 <goloaspete>1</goloaspete>
 </scorpauza>
 <echipaoaspete>poli iasi</echipaoaspete>
 <scorprelungiri>
 <golgazda>0</golgazda>
 <goloaspete>0</goloaspete>
 </scorprelungiri>
 <scorpenaltiuri>
 <golgazda>0</golgazda>
 <goloaspete>0</goloaspete>
 </scorpenaltiuri>
 <stadion>municipal</stadion>
<oras>sibiu</oras>
<competitia>superliga etapa 8 sezon regular tur</competitia>
 <orasidatastart>18.30 3 august 2024 sambata</orasidatastart>
 <nrspectatori>Romania</nrspectatori>
 <tara>5200</tara>
 <transmisdepostul>DigiSport 1 . Orange Sport 1, Prima Sport 1</transmisdepostul>
 <orasidatafinal>20.30 3 august 2024 sambata</orasidatafinal>
</meci>


			  */
			 /*
			  <meci><echipagazda></echipagazda> <scorfinal> <golgazda></golgazda> <goloaspete></goloaspete> </scorfinal> <scorpauza> <golgazda></golgazda> <goloaspete></goloaspete> </scorpauza> <echipaoaspete></echipaoaspete> <scorprelungiri> <golgazda></golgazda> <goloaspete></goloaspete> </scorprelungiri> <scorpenaltiuri> <golgazda></golgazda> <goloaspete></goloaspete> </scorpenaltiuri> <stadion></stadion><oras></oras><competitia></competitia> <orasidatastart></orasidatastart> <nrspectatori></nrspectatori> <tara></tara> <transmisdepostul></transmisdepostul> <orasidatafinal></orasidatadinal></meci>
			  */
			 /*
			  <meci>
<echipagazda></echipagazda>
 <scorfinal>
 <golgazda></golgazda>
 <goloaspete></goloaspete>
 </scorfinal>
 <scorpauza>
 <golgazda></golgazda>
 <goloaspete></goloaspete>
 </scorpauza>
 <echipaoaspete></echipaoaspete>
 <scorprelungiri>
 <golgazda></golgazda>
 <goloaspete></goloaspete>
 </scorprelungiri>
 <scorpenaltiuri>
 <golgazda></golgazda>
 <goloaspete></goloaspete>
 </scorpenaltiuri>
 <stadion></stadion>
<oras></oras>
<competitia></competitia>
 <orasidatastart></orasidatastart>
 <nrspectatori></nrspectatori>
 <tara></tara>
 <transmisdepostul></transmisdepostul>
 <orasidatafinal></orasidatadinal>
</meci>




<meci>
<echipagazda>sibiu</echipagazda>
 <scorfinal>
 <golgazda>6</golgazda>
 <goloaspete>2</goloaspete>
 </scorfinal>
 <scorpauza>
 <golgazda>4</golgazda>
 <goloaspete>1</goloaspete>
 </scorpauza>
 <echipaoaspete>poli iasi</echipaoaspete>
 <scorprelungiri>
 <golgazda>0</golgazda>
 <goloaspete>0</goloaspete>
 </scorprelungiri>
 <scorpenaltiuri>
 <golgazda>0</golgazda>
 <goloaspete>0</goloaspete>
 </scorpenaltiuri>
 <stadion>municipal</stadion>
<oras>sibiu</oras>
<competitia>superliga etapa 8 sezon regular tur</competitia>
 <orasidatastart>18.30 3 august 2024 sambata</orasidatastart>
 <nrspectatori>Romania</nrspectatori>
 <tara>5200</tara>
 <transmisdepostul>DigiSport 1 . Orange Sport 1, Prima Sport 1</transmisdepostul>
 <orasidatafinal>20.30 3 august 2024 sambata</orasidatadinal>
</meci>



			  */
			Clipboard.SetText(sxml);
			this.label16.Text = "Codul a fost generat si e in cliboard ctrl+v paste";
		}
		void Button2Click(object sender, EventArgs e)
		{
			
			this.label16.Text = "";
					
	string s = "Gazde : "+ this.textBox1.Text + " , " + "Scor final :" + this.textBox3.Text  + " - " + this.textBox4.Text  + "  Scor la pauza :  " + this.textBox6.Text  + " - " + this.textBox5.Text  + " Echipa Oaspete: " + this.textBox2.Text;
			s+=  " Goluri prelungiri : " + this.textBox10.Text  + " - " + this.textBox9.Text  + " Goluri penaltiuri : " + this.textBox8.Text  + " - " + this.textBox7.Text;
			s+=  " Stadion : " + this.textBox11.Text  + " Oras :  " + this.textBox12.Text  + " Competitia " + this.textBox13.Text  + " Ora si data start : " + this.textBox14.Text;
			s+=  " Numar spectatori :   " + this.textBox15.Text  + " Tara : " + this.textBox16.Text  + " Transmis de postul : " + this.textBox17.Text  + " Ora si data final : " + this.textBox18.Text ;
				
			/*
			 Gazde :  , Scor final : -   Scor la pauza :   -  Echipa Oaspete:  Goluri prelungiri :  -  Goluri penaltiuri :  -  Stadion :  Oras :   Competitia  Ora si data start :  Numar spectatori :    Tara :  Transmis de postul :  Ora si data final :


Gazde : sibiu , Scor final :6 - 2  Scor la pauza :  4 - 1 Echipa Oaspete: poli iasi Goluri prelungiri : 0 - 0 Goluri penaltiuri : 0 - 0 Stadion : municipal Oras :  sibiu Competitia superliga etapa 8 sezon regular tur Ora si data start : 18.30 3 august 2024 sambata Numar spectatori :   Romania Tara : 5200 Transmis de postul : DigiSport 1 . Orange Sport 1, Prima Sport 1 Ora si data final : 20.30 3 august 2024 sambata

 
			 */
			Clipboard.SetText(s);
				
				this.label16.Text = "Codul a fost generat si e in cliboard ctrl+v paste";
		}
	}
}
