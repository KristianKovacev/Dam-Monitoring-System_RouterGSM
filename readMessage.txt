 private void router_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                Invoke(new Action(() =>
                {
                    if (lastCommand.Contains("AT+CMGF") || lastCommand.Contains("AT+CMGL"))
                    {
                        string messageReceived = router.ReadExisting();
                        txtMessages.Text = String.Format("{0} - {1} ----> {2}\n", DateTime.Now, lastCommand, messageReceived) + txtMessages.Text;
                    }
                    else
                    {

                        string messageReceived = router.ReadLine();
                        txtRicevi.Text = String.Format("{0} - {1} ----> {2}\n", DateTime.Now, lastCommand, messageReceived) + txtRicevi.Text;
                    }
                }));
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReadMessages_Click(object sender, EventArgs e)
        {
            lastCommand = "AT+CMGF=1";
            router.WriteLine("AT+CMGF=1" + "\r");
            router.WriteLine("AT+CMGL=ALL" + "\r");
            txtMessages.Text = "";
        }