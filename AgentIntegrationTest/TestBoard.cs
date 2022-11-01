using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Solidus.AgentIntegration;

namespace AgentIntegrationTest
{
    public partial class TestBoard : Form
    {
        public AgentClient agent;

        public event AgentClient.CallEventHandler CallEvent;
        

        public TestBoard()
        {
            agent = new AgentClient();

            InitializeComponent();

        }

        public void TestBoard_Load(object sender, EventArgs e)
        {
            UninitializeBtn.Visible = false;
            button12.Visible = false;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Class.UserInfo test = new Class.UserInfo
            {

                #region data from UserInfo
                ChatReadyStatus = agent.GetUserInformation().ChatReadyStatus,
                EmailReadyStatus = agent.GetUserInformation().EmailReadyStatus,
                ExtensionNumber = agent.GetUserInformation().ExtensionNumber,
                LoggedOn = agent.GetUserInformation().LoggedOn,
                LoginID = agent.GetUserInformation().LoginID,
                OASID = agent.GetUserInformation().OASID,
                OASServerName = agent.GetUserInformation().OASServerName,
                OPenMediaReadyStatus = agent.GetUserInformation().OpenMediaReadyStatus,
                RecordID = agent.GetUserInformation().RecordID,
                UserName = agent.GetUserInformation().UserName
                #endregion
            };


            MessageBox.Show("Current Logged On User Info: "
                + "\n Chat Ready Status: " + test.ChatReadyStatus.ToString()
                + "\n Email Ready Status: " + test.EmailReadyStatus.ToString()
                + "\n Extension Number: " + test.ExtensionNumber.ToString()
                + "\n Logged On: " + test.LoggedOn.ToString()
                + "\n Login ID: " + test.LoginID.ToString()
                + "\n OAS ID: " + test.OASID.ToString()
                + "\n OAS Server Name: " + test.OASServerName.ToString()
                + "\n Open Media Ready Status: " + test.OPenMediaReadyStatus.ToString()
                + "\n Record ID: " + test.RecordID.ToString()
                + "\n User Name: " + test.UserName.ToString()
                );

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!agent.IsBSARunning())
            {
                MessageBox.Show("Agent is not Running");
            }
            else
            {
                MessageBox.Show("Agent is Running");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (agent.LaunchBSA())
            {
                if (!agent.Initialize())
                {
                    MessageBox.Show("Failed to Initialize Agent");
                }
            }
            else
            {
                MessageBox.Show("Failed to Launch Agent");
                    
            }

            StartAgent.Visible = false;
            CloseAgent.Visible = true;

            //agent.CloseApplication();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            agent.CloseApplication();

            InitializeBtn.Visible = true;
            UninitializeBtn.Visible = false;
        }

        private void StrtWAgent_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Class.UserloginInfo logininfo = new Class.UserloginInfo
                {
                    LogonID = loginid_txt.Text,
                    Password = password_txt.Text,
                    Extension = extension_txt.Text,
                    ExtensionPassword = extpass_txt.Text,
                    SiteName = sitename_txt.Text,
                    WebServer = webserver_txt.Text,
                    BrokerServer = brokerserver_txt.Text,
                    BrokerPort = brokerport_txt.Text
                };

                #region data from UserloginInfo
                agent.LaunchBSAWithCredentials(
                    logininfo.LogonID, 
                    logininfo.Password, 
                    logininfo.Extension, 
                    logininfo.ExtensionPassword, 
                    logininfo.SiteName, 
                    logininfo.WebServer, 
                    logininfo.BrokerServer, 
                    logininfo.BrokerPort);
                #endregion

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.ToString());
            }
            
        }

        private void InitializeBtn_Click(object sender, EventArgs e)
        {
            if (agent.Initialize())
            {
                MessageBox.Show("Initializing Succeeded");
            }
            else
            {
                MessageBox.Show("Failed to Initialized");
            }
            InitializeBtn.Visible = false;
            UninitializeBtn.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (agent.IsRegistered())
            {
                MessageBox.Show("Agent is Registered");
            }
            else
            {
                MessageBox.Show("Agent is not Registered");
            }
        }

        private void UninitializeBtn_Click(object sender, EventArgs e)
        {
            if (agent.Uninitialize())
            {
                MessageBox.Show("Agent is Un-Initialized Successfully");
            }
            else
            {
                MessageBox.Show("Agent is Failed to Un-Initialized");
            }
            UninitializeBtn.Visible = false;
            InitializeBtn.Visible = true;
        }

        private void MakeCallTo_Click(object sender, EventArgs e)
        {
            agent.MakeCall(NumberHere.ToString(),"",false);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            agent.SetReadyStatus(true, 0, null);
            agent.SetChatReadyStatus(true);
            agent.SetEmailReadyStatus(true);
            agent.SetOpenMediaReadyStatus(true);

            button12.Visible = true;
            button5.Visible = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            agent.SetReadyStatus(false, 0, null);
            agent.SetChatReadyStatus(false);
            agent.SetEmailReadyStatus(false);
            agent.SetOpenMediaReadyStatus(false);

            button5.Visible = true;
            button12.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {

                ICall[] stuff = agent.GetCalls();
                

                StringBuilder Text = new StringBuilder();
                //string[] IVRDataStr = stuff[i].IVRData[0].ToString();
                for (int i =0; i < stuff.Count();i++)
                {
                    int CountIVRData = stuff[i].CallInfo.IVRData.Count();
                    int CountIVRLabel = stuff[i].CallInfo.IVRLabels.Count();

                    //ICallInformation stuff2 = stuff[].CallInfo. 


                    Text.Append("Get Call Info:"
                         + "\n Called Number :" + CheckNullorEmpty(stuff[i].CalledNumber.ToString())
                         + "\n Caller Name :" + CheckNullorEmpty(stuff[i].CallerName.ToString())
                         + "\n Call Info :" + CheckNullorEmpty(stuff[i].CallInfo.CallingNumber.ToString() //-- using ICallInformation Properties
                         + "\n Start Time :" + CheckNullorEmpty(stuff[i].StartTime.ToString())
                         + "\n Campaign Call Info :" + CheckNullorEmpty(stuff[i].CampaignCallInfo.CallStatus.ToString() //-- using ICallInformation Properties
                         + "\n End Time :" + CheckNullorEmpty(stuff[i].EndTime.ToString())
                         + "\n Can Answer :" + CheckNullorEmpty(stuff[i].CanAnswer.ToString())
                         + "\n Can Deflect :" + CheckNullorEmpty(stuff[i].CanDeflect.ToString())
                         + "\n Can Hangup :" + CheckNullorEmpty(stuff[i].CanHangup.ToString())
                         + "\n Can Hold :" + CheckNullorEmpty(stuff[i].CanHold.ToString())
                         + "\n Can Reject :" + CheckNullorEmpty(stuff[i].CanReject.ToString())
                         + "\n Can Retrieve :" + CheckNullorEmpty(stuff[i].CanRetrieve.ToString())
                         + "\n Connected Time:" + CheckNullorEmpty(stuff[i].ConnectedTime.ToString())
                         + "\n Consulting Call Info :" + CheckNullorEmpty(stuff[i].ConsultingCallInfo.CallingNumber.ToString()) //-- using ICallInformation Properties
                         + "\n End Time :" + CheckNullorEmpty(stuff[i].EndTime.ToString())
                         + "\n ID :" + CheckNullorEmpty(stuff[i].ID.ToString())
                         + "\n In Coming :" + CheckNullorEmpty(stuff[i].Incoming.ToString())
                         + "\n IsCampaignCall :" + CheckNullorEmpty(stuff[i].IsCampaignCall.ToString() //-- using ICallInformation Properties
                         + "\n End Time :" + CheckNullorEmpty(stuff[i].StartTime.ToString())
                         //+ "\n IVRData :" + CheckNullorEmpty(stuff[i].IVRData.ToString())
                         //+ "\n IVRData Count :" + CheckNullorEmpty(count1.ToString())
                         //+ "\n IVRData Count :" + CheckNullorEmpty(stuff[i].IVRData.Count().ToString()) -- using ICallInformation Properties
                         + "\n End Time :" + CheckNullorEmpty(stuff[i].EndTime.ToString())
                         //+ "\n IVRLabels :" + CheckNullorEmpty(stuff[i].IVRLabels.ToString()) -- using ICallInformation Properties
                         //+ "\n IVRLabels Count :" + CheckNullorEmpty(count2.ToString()) -- using ICallInformation Properties
                         + "\n PhoneNumber :" + CheckNullorEmpty(stuff[i].PhoneNumber.ToString())
                         + "\n PrivateData :" + CheckNullorEmpty(stuff[i].PrivateData.ToString())
                         + "\n RecordingState:" + CheckNullorEmpty(stuff[i].RecordingState.ToString())
                         + "\n StartTime:" + CheckNullorEmpty(stuff[i].StartTime.ToString())
                         + "\n State:" + CheckNullorEmpty(stuff[i].State.ToString())
                         + "\n StateDescription:" + CheckNullorEmpty(stuff[i].StateDescription.ToString())
                         + "\n Type:" + CheckNullorEmpty(stuff[i].Type.ToString())))));

                    #region Check IVR Data & Label
                    if (CountIVRData <= 0)
                    {
                        Text.Append("\n IVRData Count : " + CountIVRData.ToString());
                        Text.Append("\n IVRData : There is No Data in IVRData");
                    }
                    else
                    {
                        for (int y = 0; y < CountIVRData; y++)
                        {
                            Text.Append("\n IVRData Count : " + CountIVRData.ToString());
                            Text.Append("\n IVRData: " + stuff[i].CallInfo.IVRData[y].ToString());
                        }
                    }

                    if (CountIVRLabel <= 0)
                    {
                        Text.Append("\n IVRLabels Count : " + CountIVRLabel.ToString());
                        Text.Append("\n IVRLabels : There is No Data in IVRLabel");
                    }
                    else
                    {
                        for (int j = 0; j < CountIVRLabel; j++)
                        {
                            Text.Append("\n IVRLabels Count : " + CountIVRLabel.ToString());
                            Text.Append("\n IVRLabels Count : " + stuff[i].CallInfo.IVRLabels[j].ToString());
                        }
                    }
                    #endregion
                }
                MessageBox.Show(Text.ToString());
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show("" + ex.ToString());
            }

        }

        public static string CheckNullorEmpty(string Input)
        {
            if (Input == "" || Input == null)
            {
                return string.Empty;
            }
            else
            {
                return Input;
            }
        }

        private void AnswerCall_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int CallID = Convert.ToInt32(CallSessionID_txt.ToString());

                agent.AnswerCall(CallID);

            }catch(Exception ex)
            {
                MessageBox.Show("" + ex.ToString());
            }
        }

        private void HldCall_Btn_Click(object sender, EventArgs e)
        { 
            try
            {
                int CallID = Convert.ToInt32(CallSessionID_txt.ToString());

                agent.HoldActiveCall();
            }
            catch(Exception ex)
            {
                MessageBox.Show("" + ex.ToString());
            }
        }

        private void Tfto_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                int CallID = Convert.ToInt32(CallSessionID_txt.ToString());

                agent.TransferCall(CallID);
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.ToString());
            }
        }
    }
}
