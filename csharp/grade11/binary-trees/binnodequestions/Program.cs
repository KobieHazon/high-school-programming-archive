using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinNodeQuestions
{
    class Program
    {


        //פעולה המדפיסה את כל הצמתים הזוגיים בעץ
        public static void PrintEven(BinNode<int> t)
        {
            if (t != null)
            {
                if (t.GetInfo()%2==0)
                 Console.WriteLine(t.GetInfo());
                PrintEven(t.GetLeft());
                PrintEven(t.GetRight());
            }
        }

        //פעולה המדפיסה את העץ לפי סריקה תחילי
        public static void PrintTree(BinNode<int> t)
        {
            if (t != null)
            {
                Console.WriteLine(t.GetInfo());
                PrintTree(t.GetLeft());
                PrintTree(t.GetRight());
            }
        }
        //פעולה המדפיסה את העץ לפי סריקה תחילי
        public static void PreOrder(BinNode<int> t)
        {
            if (t != null)
            {
                Console.WriteLine(t.GetInfo());
                PrintTree(t.GetLeft());
                PrintTree(t.GetRight());
            }
        }

        //פעולה המדפיסה את העץ לפי סריקה תוכי
        public static void InOrder(BinNode<int> t)
        {
            if (t != null)
            {
                PrintTree(t.GetLeft());
                Console.WriteLine(t.GetInfo());
                PrintTree(t.GetRight());
            }
        }

        //פעולה המדפיסה את העץ לפי סריקה סופי 
        public static void PostOrder(BinNode<int> t)
        {
            if (t != null)
            {
                PrintTree(t.GetLeft());
                PrintTree(t.GetRight());
                Console.WriteLine(t.GetInfo());
            }
        }
       

        //פעולה המדפיסה את כל העלים השמאליים
        public static void PrintChildLeftIsLeaf(BinNode<int> t)
        {
            if (t != null)
            {
                if (t.GetLeft() != null && IsLeaf(t.GetLeft()))//בן שמאלי וגם עלה
                    Console.WriteLine(t.GetLeft().GetInfo());
                PrintChildLeftIsLeaf(t.GetLeft());
                PrintChildLeftIsLeaf(t.GetRight());
            }
        }
        //n פעולה מדפיסה את הצמתים ברמה   
        public static void PrintLevel(BinNode<int> t, int n)
        {
            if (t!=null)
            {
                if (n == 0)
                    Console.WriteLine(t.GetInfo());
                PrintLevel(t.GetLeft(), n - 1);
                PrintLevel(t.GetRight(), n - 1);
            }
        }
        //פעולה מחזירה מספר העלים בעץ
        public static int NumLeaf(BinNode<int> t)
        {
            if (t == null)
                return 0;
            else if (IsLeaf(t))
                return 1;
            else return NumLeaf(t.GetLeft()) + NumLeaf(t.GetRight());
        }
        //פעולה מחזירה מספר הבנים הימניים בעץ
        public static int NumRightNode(BinNode<int> t)
        {
            if (t == null)
                return 0;
            else if (t.GetRight() != null)
                return 1 + NumRightNode(t.GetLeft()) + NumRightNode(t.GetRight());
            else return NumRightNode(t.GetLeft());
        }
        //פעולה מחזירה מספר הצמתים שיש להם 2 בנים ושווים
        public static int NumFatherSonEqual(BinNode<int> t)
        {
            if (t == null)
                return 0;
            else if (t.GetLeft()!= null && t.GetRight() != null &&
                t.GetLeft().GetInfo() == t.GetRight().GetInfo())
                return 1 + NumFatherSonEqual(t.GetLeft()) + NumFatherSonEqual(t.GetRight());
            else return NumFatherSonEqual(t.GetLeft()) + NumFatherSonEqual(t.GetRight());
        }
        //פעולה מחזירה מספר הצמתים שערכם קטן מערכו של ההורה שלהם
        public static int NumNodeLessFather(BinNode<int> t)
        {
            int c,x;
            if (t == null)
                return 0;
            c = 0;
            x=t.GetInfo();
            if (t.GetLeft() != null && x > t.GetLeft().GetInfo())
                c++;
            if (t.GetRight() != null && x > t.GetRight().GetInfo())
                c++;
            return c + NumNodeLessFather(t.GetLeft()) + NumNodeLessFather(t.GetRight());

        }
        //פעולה מחזירה סכום הצמתים בעץ
        public static int SumNodes(BinNode<int> t)
        {
            if (t == null)
                return 0;
            else return t.GetInfo() + SumNodes(t.GetLeft()) + SumNodes(t.GetRight());
        }
        //פעולה מחזירה אמת אם הצומת עלה אחרת תחזיר הפעולה שקר
        //public static bool IsLeaf(BinNode<int> bt)
        //{
        //    return (bt.GetLeft() == null) && (bt.GetRight() == null);
        //}
        //פעולה מקבלת עץ ומחזירה את סכום הסאבים
        public static int SumGrandfather(BinNode<int> t)
        {
            if (t == null)
                return 0;
            else if (t.GetLeft() != null && !IsLeaf(t.GetLeft())||
                     t.GetRight()!=null && !IsLeaf(t.GetRight()))
               return t.GetInfo() + SumGrandfather(t.GetLeft()) + SumGrandfather(t.GetRight());
            else return SumGrandfather(t.GetLeft()) + SumGrandfather(t.GetRight());
        }

        // n פעולה מחזירה מספר הצמתחים הנמצאים ברמה 
        public static int NumNodeLevel(BinNode<int> t,int n)
        {
            if (t == null)
                return 0;
            else if (n == 0)
                return 1;
            else return NumNodeLevel(t.GetLeft(), n - 1) + NumNodeLevel(t.GetRight(), n - 1);
        }
        //פעולה מקבלת עץ ומחזירה אמת אם כל הצמתים הם זוגיים
        public static int SumLevel(BinNode<int> t,int level)
        {
            if (t == null)
                return 0;
            if (level == 0)
                return t.GetInfo();
            return SumLevel(t.GetLeft(), level - 1) + SumLevel(t.GetRight(), level - 1);
        }
        //פעולה מחזירה אמת אם הצומת עלה אחרת תחזיר הפעולה שקר
        public static bool IsLeaf(BinNode<int> bt)
        {
            return (bt.GetLeft() == null) && (bt.GetRight() == null);
        }
        //פעולה מקבלת עץ ומחזירה אמת אם העץ הוא תעלומה ושקר אחרת
        public static bool IsTaloma(BinNode<int> t)
        {
            if (IsLeaf(t))//אם עלה
               return true;
            if (t.GetLeft() == null || t.GetRight() == null)
                return false;
            if (t.GetLeft().GetInfo() > 0)
                return false;
            if (t.GetRight().GetInfo() < 0)
                return false;
            return IsTaloma(t.GetLeft()) && IsTaloma(t.GetRight());
        }
        //פעולה מקבלת עץ ומחזירה אמת אם כל הצמתים בעץ זוגיים אחרת תחזיר שקר
        public static bool IsAllNodeEven(BinNode<int> t)
        {
            if (t == null)
                return true;
            else if (t.GetInfo() % 2 != 0)
                return false;
            else return IsAllNodeEven(t.GetLeft()) && IsAllNodeEven(t.GetRight()); 
        }
      
        //פעולה מקבלת עץ ומחזירה אמת אם לכל צוממת יש שני ילדים
        public static bool EachHasTwoChild(BinNode<int> t)
        {
            if (IsLeaf(t))//אם הצומת עלה
                return true;
            else if (t.GetLeft() == null || t.GetRight() == null)
                return false;
            else return EachHasTwoChild(t.GetLeft()) && EachHasTwoChild(t.GetRight());
        }
        //פעולה מחזירה אמת אם הצומת עלה אחרת תחזיר הפעולה שקר
        //public static bool IsLeaf(BinNode<int> bt)
        //{
        //    return (bt.GetLeft() == null) && (bt.GetRight() == null);
        //}
        //פעולה מקבלת עץ ומחזירה אמת אם הוא עלה או שערך שורשו שווה לסכום ערכי בניו
        //וגם כל אחד מבניו מקיים את התכונה
        public static bool EqualTowChild(BinNode<int> t)
        {
            if (IsLeaf(t))//אם צומת עלה
                return true;
            else if (t.GetLeft() == null || t.GetRight() == null)
                return false;
            else if (t.GetInfo() != t.GetLeft().GetInfo() + t.GetRight().GetInfo())
                return false;
            else return EqualTowChild(t.GetLeft()) && EqualTowChild(t.GetRight());
        }
        //פעולה מקבלת עץ ובןדקת האם עץ הוא עץ מאיר אחרת הפעולה תחזיר שקר
        //עץ נקרא מאיר לא ריק הוא עלה או שורש בעל שני בנים שכל אחד מהם הוא עץ מאיר
        //והפרש ערכי הבנים שלו אינו עולה על 2
        public static bool IsTreeMaeer(BinNode<int> t)
        {
            if (t.GetLeft() == null && t.GetRight() == null)
                return true;
            else if (t.GetLeft() == null || t.GetRight() == null)
                return false;
            else if (Math.Abs(t.GetLeft().GetInfo() - t.GetRight().GetInfo()) > 2)
                return false;
            else return IsTreeMaeer(t.GetLeft()) && IsTreeMaeer(t.GetRight());
        }
        //פעולה מקבלת עץ ובודקת האם עץ הוא עץ יורד
        //עץ יורד הוא עלה או שורש ובן אחד,כך  שערך הבן אינו גדול מערך השורש
        //והבן עץ יורד
        public static bool IsTreeDown(BinNode<int> t)
        {
            if (t.GetLeft() == null && t.GetRight() == null)
                return true;//עלה
            else if (t.GetLeft() != null && t.GetRight() != null)
                return false;//האם קיים 2 בנים
            else if (t.GetLeft() != null && t.GetInfo() < t.GetLeft().GetInfo())
                return false;
            else if (t.GetRight() != null && t.GetInfo() < t.GetRight().GetInfo())
                return false;
            else if (t.GetLeft() != null)
                return IsTreeDown(t.GetLeft());
            else return IsTreeDown(t.GetRight());
        }
        //פעולה מקבלת עץ ומחזירה אמת אם קיימים בעץ שני עלים שהם אחים
        //ושקר אחרת
        public static bool IsTwoChildLeaf(BinNode<int> t)
        {
            if  ( t==null) 
                return false;
            if (t.GetLeft()!=null && IsLeaf(t.GetLeft()) && 
                t.GetRight()!=null && (IsLeaf(t.GetRight())))
                return true;
            return IsTwoChildLeaf(t.GetLeft()) || IsTwoChildLeaf(t.GetRight());
        }
        //פעולה בונה עץ
        public static BinNode<int> CreatTree()
        {
            int x;
            x = int.Parse(Console.ReadLine());
            if (x == -1)
                return null;
            Console.WriteLine("Enter left of " + x + "(or enter -1 to null)");
            BinNode<int> left = CreatTree();
            Console.WriteLine("Enter right of " + x + "(or enter -1 to null)");
            BinNode<int> right = CreatTree();
            return new BinNode<int>(left, x, right);
        }
        //פעולה מחזירה אמת אם הצומת עלה אחרת תחזיר הפעולה שקר
        //public static bool IsLeaf(BinNode<int> bt)
        //{
        //    return (bt.GetLeft() == null) && (bt.GetRight() == null);
        //}
        // ,פעולה המוחקת את כל העלים בעץ
        public static void  RemoveAllLeaf(BinNode<int> t)
        {
            if (t != null)
            {
                if (t.GetLeft() != null && IsLeaf(t.GetLeft()))
                {
                    t.SetLeft(null);
                }
                if (t.GetRight() != null && IsLeaf(t.GetRight()))
                {
                    t.SetRight(null);
                }
                RemoveAllLeaf(t.GetLeft());
                RemoveAllLeaf(t.GetRight());
            }
        }
        //פעולה מקבלת עץ ומוסיפה לכל בן יחיד אח  הערך שלו יהיה כמו הבן היחיד
        //אם לצומת עלה לא יתבצע דבר
        public static void InsertBrother(BinNode<int> t)
        {
            if (t!=null)
            {
                if (t.GetLeft()==null&& t.GetRight()!=null)//בן יחיד ימני
                    t.SetLeft(new BinNode<int>(t.GetRight().GetInfo()));
                if (t.GetRight()==null&& t.GetLeft()!=null)//בן יחיד שמאלי
                    t.SetRight(new BinNode<int>(t.GetLeft().GetInfo()));
                InsertBrother(t.GetLeft());
                InsertBrother(t.GetRight());
            }
        }
        //פעולה מקבלת עץ ומחזירה אמת אם העץ מהווה עץ משולש ימני ואחרת שקר
        public static bool RightTreeTriangle(BinNode<int> t)
        {
            if (IsLeaf(t)) //אם צומת עלה
                return true;
            if (t.GetLeft() == null || t.GetRight() == null)//בן יחיד
                return false;
            if (!IsLeaf(t.GetLeft()))//אם בן שמאלי לא עלה
                return false;
            return RightTreeTriangle(t.GetRight());
        }
        
        //פעולה מקבלת עץ ומחזירה אמת אם קיים בעץ נכדים
        public static bool IsGrandson(BinNode<int> t)
        {
            if (t==null|| IsLeaf(t))//אם הצומת עלה
                return false;
             if (t.GetLeft()!=null && !IsLeaf(t.GetLeft())||
                 t.GetRight()!= null && !IsLeaf(t.GetRight()))
                 return true;
             return IsGrandson(t.GetLeft()) || IsGrandson(t.GetRight());
        }

        //בגרות 2007
        //פעולה מקבלת עץ ומחזירה אמת אם קיים"מסלול-אחיד" אחרת תחזיר הפעולה שקר
        //הנחה:עץ לא ריק
        public static bool OnePath(BinNode<int> t)
        {
            if (t == null)
                return false;
            if (IsLeaf(t))//אם צומת עלה
                return true;
            if (t.GetLeft()==null && t.GetRight()!=null && t.GetInfo()!=t.GetRight().GetInfo())
                return false;
            if (t.GetRight() == null && t.GetLeft() != null && t.GetInfo() != t.GetLeft().GetInfo())
                return false;
            if (t.GetLeft() != null && t.GetRight() != null &&
                t.GetLeft().GetInfo() != t.GetInfo() && t.GetRight().GetInfo() != t.GetInfo())
                return false;
            return OnePath(t.GetLeft()) || OnePath(t.GetRight());
        }
        
        //בגרות 2005 מועד מיוחד
        //הפעולה מקבלת עץ ומחזירה אמת אם העץ "רמה_בבנים" אחרת תחזיר הפעולה שקר
        //הנחה עץ לא ריק
        public static bool LevelChild(BinNode<InfoLevel> t)
        {
            if (t==null)
                return true;
            if (t.GetLeft() != null && t.GetLeft().GetInfo().GetRoot()!=t.GetInfo().GetLevel())
                return false;
            if (t.GetRight() != null && t.GetRight().GetInfo().GetRoot() != t.GetInfo().GetLevel())
                return false;
            return LevelChild(t.GetLeft()) && LevelChild(t.GetRight());
        }

        //בגרות 2005
        // הפעולה מוסיפה בן ימניn -לכל עלה בעץ שערכו גדול מ n פעולה מקבלת עץ לא ריקה ומספר
        //n שערכו שווה ל
        public static void InsertLeaf(BinNode<int> t, int n)
        {
            if (t != null)
            {
                if (IsLeaf(t) && t.GetInfo()>n)
                {
                    t.SetRight(new BinNode<int>(n));
                }
                InsertLeaf(t.GetLeft(),n);
                InsertLeaf(t.GetRight(),n);
            }
        }
        //פעולה מקבלת 2 עצים ומחזירה אמת אם שני העצים דומים בתוכן וגם במבנה
        public static bool IsEqual(BinNode<int> t1, BinNode<int> t2)
        {
            if (t1 == null && t2 == null)
                return true;
            if (t1.GetInfo() != t2.GetInfo())
                return false;
            if (t1.GetLeft() != null && t2.GetLeft() == null)
                return false;
            if (t1.GetLeft() == null && t2.GetLeft() != null)
                return false;
            if (t1.GetRight() == null && t2.GetRight() != null)
                return false;
            if (t1.GetRight() != null && t2.GetRight() == null)
                return false;
            return IsEqual(t1.GetLeft(), t2.GetLeft()) &&
                   IsEqual(t1.GetRight(), t2.GetRight());
        }
        //t2 מוכל בתוך העץ t1 פעולה מקבלת 2 עצים ומחסירה אמת אם העץ
        public static bool IsContained(BinNode<int> t1, BinNode<int> t2)
        {
            if (t1 == null)
                return true;
            if (t2 == null)
                return false;
            if (IsEqual(t1, t2))
                return true;
            return IsContained(t1, t2.GetLeft()) || IsContained(t1, t2.GetRight());
        }
      
        //פעולה מחזיר את האיבר המקסימאלי בין 3 מספרים
        public static int Max3(int x, int y, int z)
        {
            return Math.Max(Math.Max(x, y), z);
        }
        //פעולה מקבלת עץ ומחזירה את האיבר המקסימאלי בעץ
        public static int GetMax(BinNode<int> t)
        {
            if (IsLeaf(t))//צומת עלה
                return t.GetInfo();
            if (t.GetLeft() == null)
                return Math.Max(t.GetInfo(),GetMax(t.GetRight()));
            if (t.GetRight() == null)
                return Math.Max(t.GetInfo(), GetMax(t.GetLeft()));
            return Max3(t.GetInfo(),GetMax(t.GetLeft()),GetMax(t.GetRight()));
        }
        //פעולה מחזירה אמת אם מספר נמצא בעץ אחרת מחזירה הפעולה שקר
        public static bool Found(BinNode<int> t, int X)
        {
            if (t == null)
                return false;
            if (t.GetInfo() == X)
                return true;
            return Found(t.GetLeft(), X) || Found(t.GetRight(), X);
        }
        //פעולה מקבלת 2 עצים לא ריקים ובונה רשימת האיברים המשותפים לשני העצים
        public static void BuildList(BinNode<int> t1, BinNode<int> t2, List<int> lst)
        {
            if (t1 != null)
            {
                if (Found(t2, t1.GetInfo()))
                    lst.Insert(null, t1.GetInfo());
                BuildList(t1.GetLeft(), t2, lst);
                BuildList(t1.GetRight(), t2, lst);
            }
        }
        //פעולה מקבלת 2 עצים לא ריקים ומחזירה רשימה של האיברים המשותים
        public static List<int> CommonNodes(BinNode<int> t1, BinNode<int> t2)
        {
            List<int> list = new List<int>();
            BuildList(t1, t2, list);
            return list;
        }
        //פעולה מקבלת עץ ומדפיסה את הצמתים לפי רמות
        public static void LevelOrder(BinNode<int> t)
        {
            Queue<BinNode<int>> q = new Queue<BinNode<int>>();
            BinNode<int> bt;
            q.Insert(t);
            while (!q.IsEmpty())
            {
                bt = q.Remove();
                Console.WriteLine(bt.GetInfo());
                if (bt.GetLeft() != null)
                    q.Insert(bt.GetLeft());
                if (bt.GetRight() != null)
                    q.Insert(bt.GetRight());
            }
        }
        // ושקר אחרת y  והוא צאצא של צומת x פעולה מקבלת עץ ומחזירה אמת אם קיים צומת
        public static bool Descendant(BinNode<int> t,int x,int y)
        {
            if (t.GetInfo() == y)
                return Found(t.GetLeft(), x) || Found(t.GetRight(), x);
            return Descendant(t.GetLeft(), x, y) || Descendant(t.GetRight(), x, y);
        }
        //פעולה מקבלת עץ הפעולה מחזירה סכום הערכים של כל רמה בעץ לרשימה חדשה
        
        //פעולה מקבלת עץ ומדפיסה את את הצמתים שגדולים מהבנים שלהם
        public static void PrintPernt(BinNode<int> t)
        {
            if (t != null)
            {
                //קיים שני בנים וההורה גדול מהבנים
                if (t.GetLeft() != null && t.GetLeft().GetInfo() < t.GetInfo()
                    && t.GetRight() != null && t.GetRight().GetInfo() < t.GetInfo())
                    Console.WriteLine(t.GetInfo());
                //קיים בין יחיד שמאלי והוא קטו מהורה
                if (t.GetLeft()!=null && t.GetRight()==null&&
                    t.GetInfo() > t.GetLeft().GetInfo())
                    Console.WriteLine(t.GetInfo());
                //קיים בין יחיד ימני והוא קטו מהורה
                if (t.GetRight() != null && t.GetLeft() == null 
                    && t.GetInfo() > t.GetRight().GetInfo())
                    Console.WriteLine(t.GetInfo());
                PrintPernt(t.GetLeft());
                PrintPernt(t.GetRight());
            }
        }

        //2. גירסה לא רקורסיבית המשתמשת בתור - סריקה לפי רמות
        public static BinNode<int> Parent2(BinNode<int> bt, BinNode<int> child)
        {
            BinNode<int> t;
            Queue<BinNode<int>> q = new Queue<BinNode<int>>();

            q.Insert(bt);
            while (!q.IsEmpty())
            {
                t = q.Remove();
                if (t.GetLeft() == child || t.GetRight() == child)
                    return t;
                if (t.GetLeft() != null)
                    q.Insert(t.GetLeft());
                if (t.GetRight() != null)
                    q.Insert(t.GetRight());
            }
            return null;
        }
      
        //בגרות 2005
        public static void Add(BinNode<int> t, int n)
        {

            if (t != null)
            {

                if (IsLeaf(t) == true)
                {
                    if (t.GetInfo() > n)
                        t.SetRight(new BinNode<int>(n));
                }
                Add(t.GetLeft(), n);
                Add(t.GetRight(), n);
            }
        }

        //פעולה מקבלת עץ ומחזירה אמת אם העץ פרו ורבו אחרת יוחזר שקר
        public static bool ProRbo(BinNode<int> t)
        {
            if (t == null)
                return false;
            if (t.GetLeft() != null && !IsLeaf(t.GetLeft()) &&
                t.GetRight() != null && !IsLeaf(t.GetRight()))
                return true;
            return ProRbo(t.GetLeft()) || ProRbo(t.GetLeft());
        }
        //פעולה מחזירה גובה עץ
        //הנחה עץ לא ריק ואם העץ ריק יוחזר -1
        public static int Height(BinNode<int> t)
        {
            if (t == null)
                return -1;

           return 1+ Math.Max(Height(t.GetLeft()),Height(t.GetRight()));
        }
        //פעולה מחזירה הורה
        public static BinNode<int> Parent1(BinNode<int> bt, BinNode<int> child)
        {
            if ((bt == null) || (child == bt.GetLeft()) || (child == bt.GetRight()))
                return bt;

            BinNode<int> node = Parent1(bt.GetLeft(), child);

            if (node == null)
                return Parent1(bt.GetRight(), child);
            else
                return node;
        }


        //פעולה מחזירה סכום הצמתים בעץ
        //public static int SumNodes(BinNode<int> t)
        //{
        //    if (t == null)
        //        return 0;
        //    else return t.GetInfo() + SumNodes(t.GetLeft()) + SumNodes(t.GetRight());
        //}
        //פעולה מקבלת עץ ומחזירה אמת אם העץ הוא עץ סכומים אחרת יוחזר שקר
        public static bool IsTreeSum(BinNode<int> t)
        {
            if (t==null|| IsLeaf(t))
                return true;
            if (t.GetInfo() != SumNodes(t.GetLeft())+SumNodes(t.GetRight()))
                return false;
            return IsTreeSum(t.GetLeft()) && IsTreeSum(t.GetRight());
        }




        public static bool IsFull(BinNode<int> bt)
        {
            if (bt.GetLeft() == null && bt.GetRight() == null)
                return true;

            if (bt.GetLeft() == null || bt.GetRight() == null)
                return false;

            return IsFull(bt.GetLeft()) && IsFull(bt.GetRight());
        }

        public static BinNode<int> BuildTree(int[] preorder, int[] inorder)
        {
            BinNode<int> BT = new BinNode<int>(preorder[0]);
            int i = 0;
            while (preorder[0] != inorder[i])
                i++;

            if (i > 0)
            {
                int[] preorderL = new int[i];
                int[] inorderL = new int[i];
                for (int j = 0; j < i; j++)
                {
                    preorderL[j] = preorder[j + 1];
                    inorderL[j] = inorder[j];
                }
                BT.SetLeft(BuildTree(preorderL, inorderL));
            }

            if (i < inorder.Length - 1)
            {
                int[] preorderR = new int[inorder.Length - 1 - i];
                int[] inorderR = new int[inorder.Length - 1 - i];
                for (int j = i + 1; j < inorder.Length; j++)
                {
                    preorderR[j - i - 1] = preorder[j];
                    inorderR[j - i - 1] = inorder[j];
                }
                BT.SetRight(BuildTree(preorderR, inorderR));
            }

            return BT;
        }

        public static int SumRightSingle(BinNode<int> BT)
        {
            if (BT == null)
                return 0;
            int Temp = 0;
            if (BT.GetLeft() == null && BT.GetRight() != null)
            {
                Temp = BT.GetRight().GetValue();
            }

            return Temp + SumRightSingle(BT.GetLeft()) + SumRightSingle(BT.GetRight());
        }

        public static int SumLeftSingle(BinNode<int> BT)
        {
            if (BT == null)
                return 0;
            int Temp = 0;
            if (BT.GetRight() == null && BT.GetLeft() != null)
            {
                Temp = BT.GetLeft().GetValue();
            }

            return Temp + SumRightSingle(BT.GetLeft()) + SumLeftSingle(BT.GetRight());
        }

        public static int KidDif(BinNode<int> BT) // תרגיל 21
        {
            return (SumRightSingle(BT) - SumLeftSingle(BT));
        }

        public static int MaxBinSeaTree(BinNode<int> bst)
        {
            if (bst.GetRight() == null)
                return bst.GetValue();
            return MaxBinSeaTree(bst.GetRight());
        }


        static void Main(string[] args)
        {
            BinNode<int> BT = new BinNode<int>(new BinNode<int>(8), 18, new BinNode<int>(null, 5, new BinNode<int>(7)));
            Console.WriteLine(KidDif(BT));
        }
    }
}
