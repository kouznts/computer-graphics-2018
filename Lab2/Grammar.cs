using System;
using System.Text;

namespace Lab2
{
    public class Grammar
    {
        #region статика
        public static readonly string AXIOM = "F";
        public static readonly string RULE = "F[+FF][-FF]F[-F][+F]F";
        public static readonly string RULE_X = "";
        public static readonly string RULE_Y = "";
        public static readonly double ANGLE = Math.PI / 5;
        public static readonly int MAX_STEPS = 7;
        #endregion /статика

        public string Axiom { get; }
        public string Rule { get; }
        public string RuleX { get; }
        public string RuleY { get; }
        public double Angle { get; }

        private int currStep;
        private string code;

        public Grammar(string axiom, string rule, string ruleX, string ruleY, double angle)
        {
            Axiom = axiom;
            Rule = rule;
            RuleX = ruleX;
            RuleY = ruleY;
            Angle = angle;

            currStep = 0;
            code = Axiom;
        }

        public int CurrStep
        {
            get
            {
                return currStep;
            }

            set
            {
                if (value < 0)
                    throw new IndexOutOfRangeException();

                if (value > MAX_STEPS)
                    throw new IndexOutOfRangeException();

                currStep = value;
                Code = Axiom;

            }
        }

        public string Code
        {
            get
            {
                return code;
            }

            private set
            {
                StringBuilder sbCode = new StringBuilder(value);

                for (int i = 1; i <= currStep; i++)
                {
                    StringBuilder sbCurrStepCode = new StringBuilder();

                    for (int j = 0; j < sbCode.Length; j++)
                    {
                        switch (sbCode[j])
                        {
                            case 'F':
                                sbCurrStepCode.Append(Rule);
                                break;

                            case 'X':
                                sbCurrStepCode.Append(RuleX);
                                break;

                            case 'Y':
                                sbCurrStepCode.Append(RuleY);
                                break;

                            default:
                                sbCurrStepCode.Append(sbCode[j]);
                                break;
                        }
                    }

                    sbCode = sbCurrStepCode;
                }

                code = sbCode.ToString();
            }
        }
    }
}