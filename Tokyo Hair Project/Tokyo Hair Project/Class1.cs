using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace Tokyo_Hair_Project
{
    public class DataMover
    {
        public string name;
        public string eMail;
        public string password;
        public string strTotal;
        public string printTotal;
        public string purchCode;
        public string lowerlbl;
        public string clublbl;
        public string upperlbl;
        public string cardName;
        public int age;
        readonly int maxTixLower = 200;
        readonly int maxTixClub = 75;
        readonly int maxTixUpper = 200;
        public int purchLower;
        public int purchClub;
        public int purchUpper;
        public int tixLower = 0;
        public int tixClub = 0;
        public int tixUpper = 0;
        public int rndnum = 0;
        public int lowerRed = 0;
        public int clubRed = 0;
        public int upperRed = 0;
        public long cardNumber;
        public int CSV;
        readonly Regex reg = new Regex(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        int tixLowerLeft;
        int tixClubLeft;
        int tixUpperLeft;
        Boolean soldout1 = false;
        Boolean soldout2 = false;
        Boolean soldout3 = false;

        public void SetName(string name_)
        {
            this.name = name_;
        }
        public void SetAge(int age_)
        {
            this.age = age_;
        }
        public void SetEmail(string eMail_)
        {
            this.eMail = eMail_;
        }
        public void SetPassword(string password_)
        {
            this.password = password_;
        }
        public void SetLowerTix(int tixLower_)
        {
            this.tixLower = tixLower_;
        }
        public void SetPurchLower(int purchLower_)
        {
            this.purchLower = purchLower_;
        }
        public void SetLowerlbl(string lowerlbl_)
        {
            this.lowerlbl = lowerlbl_;
        }
        public void SetClubTix(int tixClub_)
        {
            this.tixClub = tixClub_;
        }
        public void SetPurchClub(int purchClub_)
        {
            this.purchClub = purchClub_;
        }
        public void SetClublbl(string clublbl_)
        {
            this.clublbl = clublbl_;
        }
        public void SetUpperTix(int tixUpper_)
        {
            this.tixUpper = tixUpper_;
        }
        public void SetPurchUpper(int purchUpper_)
        {
            this.purchUpper = purchUpper_;
        }
        public void SetUpperlbl(string upperlbl_)
        {
            this.upperlbl = upperlbl_;
        }
        public void SetLowerRed(int lowerRed_)
        {
            this.lowerRed = lowerRed_;
        }
        public void SetClubRed(int clubRed_)
        {
            this.clubRed = clubRed_;
        }
        public void SetUpperRed(int upperRed_)
        {
            this.upperRed = upperRed_;
        }
        public void SetCardNumber(long cardNumber_)
        {
            this.cardNumber = cardNumber_;
        }
        public void SetCardName(string cardName_)
        {
            this.cardName = cardName_;
        }
        public void SetCSV(int CSV_)
        {
            this.CSV = CSV_;
        }
        public void SetSoldOut1(Boolean soldout1_)
        {
            this.soldout1 = soldout1_;
        }
        public void SetSoldOut2(Boolean soldout2_)
        {
            this.soldout2 = soldout2_;
        }
        public void SetSoldOut3(Boolean soldout3_)
        {
            this.soldout3 = soldout3_;
        }
        public void PageClear()
        {
            tickets tix = new tickets();
            tix.ClearPage();
        }
        public void OpenConfirm()
        {

        }
        public void OpenAccountCreation()
        {
            accountCreation acc = new accountCreation();
            acc.Activate();
            acc.Show();
        }

        public void OpenAdmin()
        {
            Admin adm = new Admin();
            adm.Activate();
            adm.Show();
        }

        public void RandomMusic()
        {
            Random track = new Random();
            int rndtrk = track.Next(1, 10);
            if (rndtrk >= 1 && rndtrk < 4)
            {
                SoundPlayer Mytrack = new SoundPlayer();

                Mytrack.SoundLocation = "Track1.wav";
                Mytrack.Load();
                Mytrack.Play();
            }
            if (rndtrk >= 4 && rndtrk < 7)
            {
                SoundPlayer Mytrack2 = new SoundPlayer();

                Mytrack2.SoundLocation = "Track2.wav";
                Mytrack2.Load();
                Mytrack2.Play();
            }
            if(rndtrk >= 7)
            {
                SoundPlayer Mytrack3 = new SoundPlayer();

                Mytrack3.SoundLocation = "track3.wav";
                Mytrack3.Load();
                Mytrack3.Play();
            }
            
            
        }
        public void PlayHello()
        {
            SoundPlayer Mytone = new SoundPlayer();

            Mytone.SoundLocation = "hello.wav";
            Mytone.Load();
            Mytone.Play();
        }
        public void PlayExcuseMe()
        {
            SoundPlayer Mytone = new SoundPlayer();

            Mytone.SoundLocation = "excuse me.wav";
            Mytone.Load();
            Mytone.Play();
        }
        public void PlayGood()
        {
            SoundPlayer Mytone = new SoundPlayer();

            Mytone.SoundLocation = "good.wav";
            Mytone.Load();
            Mytone.Play();
        }
        public void PlayGoodbye()
        {
            SoundPlayer Mytone = new SoundPlayer();

            Mytone.SoundLocation = "goodbye.wav";
            Mytone.Load();
            Mytone.Play();
        }
        public void PlayLoudNo()
        {
            SoundPlayer Mytone = new SoundPlayer();

            Mytone.SoundLocation = "loud no.wav";
            Mytone.Load();
            Mytone.Play();
        }
        public void PlayQuestion()
        {
            SoundPlayer Mytone = new SoundPlayer();

            Mytone.SoundLocation = "question.wav";
            Mytone.Load();
            Mytone.Play();
        }
        public void PlaySassyNo()
        {
            SoundPlayer Mytone = new SoundPlayer();

            Mytone.SoundLocation = "sassy no.wav";
            Mytone.Load();
            Mytone.Play();
        }
        public void PlayThisSoundsFun()
        {
            SoundPlayer Mytone = new SoundPlayer();

            Mytone.SoundLocation = "this sounds fun.wav";
            Mytone.Load();
            Mytone.Play();
        }
        public void PlayWeDidIt()
        {
            SoundPlayer Mytone = new SoundPlayer();

            Mytone.SoundLocation = "we did it.wav";
            Mytone.Load();
            Mytone.Play();
        }
        public void PlayWhatIsThis()
        {
            SoundPlayer Mytone = new SoundPlayer();

            Mytone.SoundLocation = "what is this.wav";
            Mytone.Load();
            Mytone.Play();
        }
        public void PlaySorry()
        {
            SoundPlayer Mytone = new SoundPlayer();

            Mytone.SoundLocation = "sorry.wav";
            Mytone.Load();
            Mytone.Play();
        }

        public string GetName()
        {
            return this.name;
        }

        public string GetEmail()
        {
            return this.eMail;
        }

        public string GetPassword()
        {
            return this.password;
        }

        public int GetAge()
        {
            return this.age;
        }
        public int GetLowerTix()
        {
            return this.tixLower;
        }
        public int GetPurchLower()
        {
            return this.purchLower;
        }
        public string GetLowerlbl()
        {
            return this.lowerlbl;
        }
        public int GetClubTix()
        {
            return this.tixClub;
        }
        public int GetPurchClub()
        {
            return this.purchClub;
        }
        public string GetClublbl()
        {
            return this.clublbl;
        }
        public int GetUpperTix()
        {
            return this.tixUpper;
        }
        public int GetPurchUpper()
        {
            return this.purchUpper;
        }
        public string GetUpperlbl()
        {
            return this.upperlbl;
        }
        public int GetLowerRed()
        {
            return this.lowerRed;
        }
        public int GetClubRed()
        {
            return this.clubRed;
        }
        public int GetUpperRed()
        {
            return this.upperRed;
        }
        public Boolean GetSoldOut1()
        {
            return this.soldout1;
        }
        public Boolean GetSoldOut2()
        {
            return this.soldout2;
        }
        public Boolean GetSoldOut3()
        {
            return this.soldout3;
        }
        public long GetCardNumber()
        {
            return this.cardNumber;
        }
        public string GetCardName()
        {
            return this.cardName;
        }
        public int GetCSV()
        {
            return this.CSV;
        }
               


        public void ArrayWorks()
        {
            String[] customers = new string[4];
            customers[0] = GetName();
            customers[1] = this.age.ToString();
            customers[2] = GetEmail();
            customers[3] = GetPassword();
            //save to file           
            String strSaved;
            strSaved = String.Join(",", customers);
            File.AppendAllText("customers.txt", strSaved + "\r\n");
        }
        public void DataChecker()
        {
            login log = new login();
            if (age > 16)
            {
                if (password == "")
                {
                    MessageBox.Show("Password required!");
                    bool isValid = reg.IsMatch(eMail.Trim());
                    if (isValid)
                    {
                        PlayWeDidIt();
                        MessageBox.Show("Welcome New TixMaster Customer!" + name);
                        log.Activate();
                        log.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Email.");
                    }
                }
            }
            else if (age <= 16)
            {
                MessageBox.Show("Must be older than 16 to purchase tickets.  Please have a parent or guardian complete this purchase.");
            }
        }
        public void AcccountCreation()
        {
            ArrayWorks();
            DataChecker();
        }

        public void CustLogin(string[] customers)
        {
           
        }
    
               
        public void PurchaseTickets()
        {
            string[] tixSource = File.ReadAllLines("ticket totals.txt");

            int tixPurchLower = GetPurchLower();
            int tixPurchClub = GetPurchClub();
            int tixPurchUpper = GetPurchUpper();
            int lowerCost = 125;
            int clubCost = 75;
            int upperCost = 50;
            int tixLower = 0;
            int tixClub = 0;
            int tixUpper = 0;


            var tickets = from ticks in tixSource
                          let total = ticks.Split(',')
                          let lower = total[0]
                          let club = total[1]
                          let upper = total[2]
                          select new { lower, club, upper };
            foreach (var i in tickets)
            {
                tixLower += int.Parse(i.lower);
                tixClub += int.Parse(i.club);
                tixUpper += int.Parse(i.upper);
            }


            tixLowerLeft = maxTixLower - tixLower - tixPurchLower;
            tixClubLeft = maxTixClub - tixClub - tixPurchClub;
            tixUpperLeft = maxTixUpper - tixUpper - tixPurchUpper;

            if (tixPurchLower != 0 || tixPurchClub != 0 || tixPurchUpper != 0)
            {
                if (tixLowerLeft - tixPurchLower <= 0)
                {
                    //PlaySorry();
                    MessageBox.Show("Please select a smaller amount of tickets/nAs we do not have the amount you have requested left.");
                }
                    if (tixClubLeft - tixPurchClub <= 0)
                    {
                        //PlaySorry();
                        MessageBox.Show("Please select a smaller amount of tickets/nAs we do not have the amount you have requested left.");
                    }
                        if (tixUpperLeft - tixPurchUpper <= 0)
                        {
                            //PlaySorry();
                            MessageBox.Show("Please select a smaller amount of tickets/nAs we do not have the amount you have requested left.");
                        }
                    

                


                double lowerTotal = lowerCost * tixPurchLower;
                double clubTotal = clubCost * tixPurchClub;
                double upperTotal = upperCost * tixPurchUpper;

                double totalCost = lowerTotal + clubTotal + upperTotal;
                if (totalCost == 0)
                {
                    SetTotal("0");
                    SetPrintTotal("0");
                }
                else
                {
                    SetTotal(totalCost.ToString());
                    SetPrintTotal(totalCost.ToString("c"));
                    GetPrintTotal();
                }

                String strTixLower = tixPurchLower.ToString();
                String strTixClub = tixPurchClub.ToString();
                String strTixUpper = tixPurchUpper.ToString();
                string strTotal = GetTotal();

                String[] ticketSales = new string[4];
                ticketSales[0] = strTixLower;
                ticketSales[1] = strTixClub;
                ticketSales[2] = strTixUpper;
                ticketSales[3] = strTotal;

                String strCost = String.Join(",", ticketSales);
                File.AppendAllText("ticket totals.txt", strCost + "\r\n");
                
            }
        
        }
        public void SetPrintTotal(string printTotal_)
        {
            this.printTotal = printTotal_;
        }
        public void SetTotal(string strTotal_)
        {
            this.strTotal = strTotal_;
        }
        public string GetPrintTotal()
        {
            return this.printTotal;
        }
        public string GetTotal()
        {
            return this.strTotal;
        }
        public void SetPurchCode(int rndnum_)
        {
            this.rndnum = rndnum_;
        }
        public int GetPurchCode()
        {
            return this.rndnum;
        }

        public void CheckCardData()
        {
            long testCardNumber;
            int testCSV;

            bool numValid = true;
            try
            {
                testCardNumber = GetCardNumber();
            }
            catch
            {
                //PlayWhatIsThis();
                MessageBox.Show("Please enter numbers only.");
                numValid = false;
            }

            bool codeValid = true;
            try
            {
                testCSV = GetCSV();
            }
            catch
            {
                //PlayWhatIsThis();
                MessageBox.Show("Please enter numbers only.");
                codeValid = false;
            }

            if (numValid && codeValid)
            {
                if (cardNumber < 0000000000000001 || cardNumber > 9999999999999999)
                {
                    //PlaySassyNo();
                    MessageBox.Show("Card number format invalid");
                }
                if (CSV < 001 || CSV > 999)
                {
                    //PlaySassyNo();
                    MessageBox.Show("CSV code format invalid");
                }
                else
                {
                    ConfirmBox();
                    PlayWeDidIt();
                }
            }
        }
        public void ConfirmBox()
        {
            Randomizer();
            PurchChecker();
            string name = GetName();
            string email = GetEmail();
            string low = GetPurchLower().ToString();
            string club = GetPurchClub().ToString();
            string up = GetPurchUpper().ToString();
            string tot = GetTotal();
            string code = this.rndnum.ToString();

            DialogResult result = (MessageBox.Show("Rock On " + name + "!!!!!!!!!" + "\n" + "You have " + low + " Lower Box, " + club + " Club " +
                "Deck, and " + up + " UpperDeck seats ready for purchase.\n$" + tot + " is your purchase price today.\nPlease confirm or cancel below."
                  + "Please click Yes No or Cancel", "Confirm ", MessageBoxButtons.YesNoCancel));

            if (result == DialogResult.Cancel)
                {
                PlayWhatIsThis();
                MessageBox.Show("Purchase cancelled");
                }
            if (result == DialogResult.No)
            {
                DialogResult result2 = (MessageBox.Show("Do you need to start the order over? ", "Confirm", MessageBoxButtons.YesNo));
                if (result2 == DialogResult.No)
                {
                    PlayGoodbye();
                    MessageBox.Show("Ok we can rock out next time!");
                }
                if (result2 == DialogResult.Yes)
                {
                    PlayGood();
                    MessageBox.Show("Rock on man!!!!!!!!!!!!!!!");
                    PurchaseTickets();
                }
            }
            if (result == DialogResult.Yes)
            {
                PlayThisSoundsFun();
                MessageBox.Show("Order confirmed brother!" + "\n" + "Write down your purchase confirmation code:" + code + "\n" + "We will rock out on the 8th of July!!!!" + "\n" + "Confirmation has been sent to: " + email);
                SaveTixData();
            }
        }
        public void Randomizer()
        {
            Random r = new Random();
            rndnum = r.Next(1000, 9999);
        }
        public void PurchChecker()
        { 
            string[] dups = File.ReadAllLines("Customer Data.txt");

            string[] confirm = new string[1];
            var confirmed = from codes in dups
                            let conf = codes.Split(',')
                            let purchCode = conf[6]
                            select new { purchCode };                            

            foreach (var code in confirmed)
            {
                int codes = int.Parse(code.purchCode);
                if (rndnum == codes)
                {
                    rndnum = 0;
                    Randomizer();
                }
                else
                {
                    SetPurchCode(rndnum);
                }
            }
        }

        public void SaveTixData()
        {
            string[] custData = new string[10];

            custData[0] = GetName();
            custData[1] = GetEmail();
            custData[2] = this.purchLower.ToString();
            custData[3] = this.purchClub.ToString();
            custData[4] = this.purchUpper.ToString();
            custData[5] = GetTotal();
            custData[6] = this.rndnum.ToString();
            custData[7] = this.cardNumber.ToString();
            custData[8] = GetCardName();
            custData[9] = this.CSV.ToString();
            
            string strFinal = string.Join(",", custData);

            File.AppendAllText("Customer Data.txt", strFinal + "\r\n");
        }
    }
}
