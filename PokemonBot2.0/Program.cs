using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonBot2._0;
using NUnit.Framework;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace PokemonBot2._0
{
    class Program
    {
        static ChromeDriver driver;
        static string baseURL = "http://play.pokemonshowdown.com";
        static string team = "Latios @ Life Orb  \nAbility: Levitate  \nEVs: 252 SpA / 4 SpD / 252 Spe  \nTimid Nature  \n- Memento  \n- Draco Meteor  \n- Psyshock  \n- Defog  \n\nSmeargle @ Focus Sash  \nAbility: Own Tempo  \nEVs: 248 HP / 8 SpD / 252 Spe  \nTimid Nature  \n- Spore  \n- Dark Void  \n- Parting Shot  \n- Sticky Web  \n\nCharizard-Mega-X @ Charizardite X  \nAbility: Blaze  \nEVs: 252 Atk / 4 SpD / 252 Spe  \nAdamant Nature  \n- Flare Blitz  \n- Dragon Claw  \n- Roost  \n- Dragon Dance  \n\nScrafty @ Leftovers  \nAbility: Shed Skin  \nEVs: 248 HP / 252 SpD / 8 Spe  \nCareful Nature  \n- Bulk Up  \n- Rest  \n- Knock Off  \n- Drain Punch  \n\nClefable @ Leftovers  \nAbility: Magic Guard  \nEVs: 248 HP / 252 Def / 8 Spe  \nBold Nature  \n- Moonblast  \n- Heal Bell  \n- Thunder Wave  \n- Soft-Boiled  \n\nGarchomp @ Rocky Helmet  \nAbility: Rough Skin  \nEVs: 248 HP / 240 Def / 20 Spe  \nImpish Nature  \n- Dragon Tail  \n- Earthquake  \n- Stealth Rock  \n- Endure";

        static void Main(string[] args)
        {
            using (driver = new ChromeDriver())
            {
                Console.WriteLine();
                StartLoadAndFindOUGame();
                SmeargleGameLoop();
                Console.ReadLine();
            }
        }

        static Pokemon[] ScrapeYourTeam()
        {
            Pokemon[] ghee = new Pokemon[6] { new Pokemon(), new Pokemon(), new Pokemon(), new Pokemon(), new Pokemon(), new Pokemon()};
            for (int i = 2; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    string xpathed = "//div[" + i + "]/span[" + j + "]";
                    string pokestring = driver.FindElement(By.XPath(xpathed)).GetAttribute("title");
                    if (pokestring.Contains(" "))
                    {
                        ghee[(i - 2) * 3 + j - 1].Name = pokestring.Substring(0, pokestring.IndexOf(' '));
                    }
                    else
                    {
                        ghee[(i - 2) * 3 + j - 1].Name = pokestring.Substring(0);
                    }
                    if (ContainsDigit(pokestring))
                    {
                        if (pokestring.Contains("|"))
                        {
                            ghee[(i - 2) * 3 + j - 1].Health = Convert.ToDouble(pokestring.Substring(pokestring.IndexOf('(') + 1, pokestring.IndexOf('%') - pokestring.IndexOf('(') - 1));
                            ghee[(i - 2) * 3 + j - 1].Status = pokestring.Substring(pokestring.IndexOf('|') + 1, 3);
                        }
                        else
                        {
                            ghee[(i - 2) * 3 + j - 1].Health = Convert.ToDouble(pokestring.Substring(pokestring.IndexOf('(') + 1, pokestring.IndexOf('%') - pokestring.IndexOf('(') - 1));
                            ghee[(i - 2) * 3 + j - 1].Status = "None";
                        }
                    }
                    else if (pokestring.Contains("fainted"))
                    {
                        ghee[(i - 2) * 3 + j - 1].Health = 0;
                        ghee[(i - 2) * 3 + j - 1].Status = "Fainted";
                    }
                    else if (pokestring.Contains("active"))
                    {
                        string temp = driver.FindElementByXPath("//div[@class='hptext']").Text;
                        ghee[(i - 2) * 3 + j - 1].Health = Convert.ToDouble(temp.Substring(0, temp.IndexOf('%') - 1));
                        try
                        {
                            ghee[(i - 2) * 3 + j - 1].Status = driver.FindElementByXPath("//div[@class='status']/*[1]").Text.ToLower();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.ToString());
                            ghee[(i - 2) * 3 + j - 1].Status = "None";
                        }
                    }
                    else
                    {
                        ghee[(i - 2) * 3 + j - 1].Health = 100;
                        ghee[(i - 2) * 3 + j - 1].Status = "None";
                    }
                }
            }

            ghee[3].Name = team.Substring(team.IndexOf("\n\n", team.IndexOf("\n\n", team.IndexOf("\n\n") + 5) + 5) + 2, team.IndexOf(' ', team.IndexOf("\n\n", team.IndexOf("\n\n", team.IndexOf("\n\n") + 5) + 5) + 3 - team.IndexOf("\n\n", team.IndexOf("\n\n", team.IndexOf("\n\n") + 5) + 5) + 3));
            return ghee;
        }

        static Pokemon[] ScrapeOppTeam()
        {
            Pokemon[] ghee = new Pokemon[6] { new Pokemon(), new Pokemon(), new Pokemon(), new Pokemon(), new Pokemon(), new Pokemon() };
            for (int i = 2; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    string pokestring = driver.FindElement(By.XPath("//div[8]/div/div[" + i + "]/span[" + j + "]")).GetAttribute("title");
                    if (pokestring.Contains(" "))
                    {
                        ghee[(i - 2) * 3 + j - 1].Name = pokestring.Substring(0, pokestring.IndexOf(' '));
                    }
                    else
                    {
                        ghee[(i - 2) * 3 + j - 1].Name = pokestring.Substring(0);
                    }
                    if (ContainsDigit(pokestring))
                    {
                        if (pokestring.Contains("|"))
                        {
                            ghee[(i - 2) * 3 + j - 1].Health = Convert.ToDouble(pokestring.Substring(pokestring.IndexOf('(') + 1, pokestring.IndexOf('%') - pokestring.IndexOf('(') - 1));
                            ghee[(i - 2) * 3 + j - 1].Status = pokestring.Substring(pokestring.IndexOf('|') + 1, 3);
                        }
                        else
                        {
                            ghee[(i - 2) * 3 + j - 1].Health = Convert.ToDouble(pokestring.Substring(pokestring.IndexOf('(') + 1, pokestring.IndexOf('%') - pokestring.IndexOf('(') - 1));
                            ghee[(i - 2) * 3 + j - 1].Status = "None";
                        }
                    }
                    else if (pokestring.Contains("fainted"))
                    {
                        ghee[(i - 2) * 3 + j - 1].Health = 0;
                        ghee[(i - 2) * 3 + j - 1].Status = "Fainted";
                    }
                    else if (pokestring.Contains("active"))
                    {
                        string temp = driver.FindElementByXPath("//div[@class='hptext']").Text;
                        ghee[(i - 2) * 3 + j - 1].Health = Convert.ToDouble(temp.Substring(0, temp.IndexOf('%') - 1));
                        try
                        {
                            ghee[(i - 2) * 3 + j - 1].Status = driver.FindElementByXPath("//div[@class='status']/*[1]").Text.ToLower();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.ToString());
                            ghee[(i - 2) * 3 + j - 1].Status = "None";
                        }
                    }
                    else
                    {
                        ghee[(i - 2) * 3 + j - 1].Health = 100;
                        ghee[(i - 2) * 3 + j - 1].Status = "None";
                    }
                }
            }
            return ghee;
        }

        static private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        static public bool ContainsDigit(String s)
        {
            bool containsDigit = false;

            if (s != null && s.Length != 0)
            {
                foreach (char c in s.ToCharArray())
                {
                    if (containsDigit = char.IsDigit(c))
                    {
                        break;
                    }
                }
            }

            return containsDigit;
        }

        static public void StartLoadAndFindOUGame(string a)
        {
            driver.Navigate().GoToUrl(baseURL + "/");
            Thread.Sleep(5000);
            driver.FindElement(By.Name("close")).Click();
            driver.FindElement(By.CssSelector("button.closebutton")).Click();
            driver.FindElement(By.Name("joinRoom")).Click();
            driver.FindElement(By.Name("new")).Click();
            driver.FindElement(By.CssSelector("input.textbox.teamnameedit")).Click();
            driver.FindElement(By.CssSelector("input.textbox.teamnameedit")).Clear();
            new SelectElement(driver.FindElement(By.CssSelector("select[name=\"format\"]"))).SelectByText("OU");
            driver.FindElement(By.Name("import")).Click();
            driver.FindElement(By.CssSelector("textarea.textbox")).Clear();
            driver.FindElement(By.CssSelector("textarea.textbox")).SendKeys(a);
            driver.FindElement(By.XPath("(//button[@name='saveImport'])[2]")).Click();
            driver.FindElement(By.CssSelector("i.fa.fa-times-circle")).Click();
            driver.FindElement(By.Name("login")).Click();
            driver.FindElement(By.Name("username")).Click();
            driver.FindElement(By.Name("username")).Clear();
            driver.FindElement(By.Name("username")).SendKeys("Doggo Hustle");
            Thread.Sleep(1000);
            driver.FindElement(By.CssSelector("button[type=\"submit\"]")).Click();
            driver.FindElement(By.Name("format")).Click();
            driver.FindElement(By.XPath("(//button[@name='selectFormat'])[3]")).Click();
            driver.FindElement(By.Name("search")).Click();
            WaitForMove();
        }

        static public void StartLoadAndFindOUGame()
        {
            StartLoadAndFindOUGame(team);
        }

        static public void FindOUGame()
        {
            driver.FindElement(By.CssSelector("button[type=\"submit\"]")).Click();
            driver.FindElement(By.Name("format")).Click();
            driver.FindElement(By.XPath("(//button[@name='selectFormat'])[3]")).Click();
            driver.FindElement(By.Name("search")).Click();
        }

        static public void WaitForMove()
        {
            for (int second = 0; ; second++)
            {
                if (second >= 150) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.XPath("(//button[@name='chooseTeamPreview'])[6]"))) break;
                }
                catch (Exception)
                { }
                Thread.Sleep(1000);
            }
            Thread.Sleep(2000);
        }

        static public void SmeargleGameLoop()
        {

        }
    }
}
