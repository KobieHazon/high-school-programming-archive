using System;
using Unit4.CollectionsLib;


public class Chap10ExSolutions
{
    public static void Main(string[] args)
    {
        buildExpTree();
    }


    // =================== תשובה לתרגיל 10 פרק 10 ======================
    // רשימה של איברי העץ בסדר של סריקה לפי רמות
    public static List<int> LevelOrderList(BinNode<int> bt)
    {
        Node<int> pos = null;
        List<int> lst = new List<int>();

        BinNode<int> node;
        Queue<BinNode<int>> q = new Queue<BinNode<int>>();

        q.Insert(bt);
        while (!q.IsEmpty())
        {
            node = q.Remove();
            pos = lst.Insert(pos, node.GetInfo());
            if (node.GetLeft() != null)
                q.Insert(node.GetLeft());
            if (node.GetRight() != null)
                q.Insert(node.GetRight());
        }

        return lst;
    }


    // =================== תשובה לתרגיל 11 פרק 10 ======================
    // ספירת תווים
    public static int Count(BinNode<char> bt, char ch)
    {
        if (bt == null)
            return 0;

        int exists = 0;
        if (bt.GetInfo() == ch)
            exists = 1;

        return exists + Count(bt.GetLeft(), ch) + Count(bt.GetRight(), ch);
    }


    // =================== תשובה לתרגיל 12 פרק 10 ======================
    // הדפסת מחרוזות
    public static void Printstrings(BinNode<string> bt, char ch)
    {
        if (bt != null)
        {
            if (bt.GetInfo().IndexOf(ch) != -1)
                Console.WriteLine(bt.GetInfo());
            Printstrings(bt.GetLeft(), ch);
            Printstrings(bt.GetRight(), ch);
        }
    }

    // =================== תשובה לתרגיל 13 פרק 10 ======================
    // החלפת מחרוזות
    public static void Replace(BinNode<string> bt, string s1, string s2)
    {
        if (bt != null)
        {
            if (bt.GetInfo().Equals(s1))
                bt.SetInfo(s2);
            Replace(bt.GetLeft(), s1, s2);
            Replace(bt.GetRight(), s1, s2);
        }
    }


    // =================== תשובה לתרגיל 14 פרק 10 ======================
    // גובה עץ
    public static int Height(BinNode<int> tree)
    {
        int hl = 0;
        int hr = 0;

        if (tree.GetLeft() != null)
            hl = 1 + Height(tree.GetLeft());
        if (tree.GetRight() != null)
            hr = 1 + Height(tree.GetRight());

        return Math.Max(hl, hr);
    }


    // =================== תשובה לתרגיל 15 פרק 10 ======================
    // מספר צמתים ברמה נתונה בעץ
    public static int NumNodesInLevel(BinNode<int> bt, int level)
    {
        if (bt == null)
            return 0;

        if (level == 0)
            return 1;

        return NumNodesInLevel(bt.GetLeft(), level - 1) + NumNodesInLevel(bt.GetRight(), level - 1);
    }


    // =================== תשובה לתרגיל 16 פרק 10 ======================
    // שתי גירסאות: בניית עץ זהה
    // 1.
    public static BinNode<int> BuildIdent1(BinNode<int> bt)
    {
        if (bt == null)
            return null;
        return new BinNode<int>(BuildIdent1(bt.GetLeft()), bt.GetInfo(), BuildIdent1(bt.GetRight()));
    }

    // 2. 
    public static BinNode<string> BuildIdent2(BinNode<string> bt)
    {
        BinNode<string> left = null;
        BinNode<string> right = null;

        if (bt.GetLeft() != null)
            left = BuildIdent2(bt.GetLeft());
        if (bt.GetRight() != null)
            right = BuildIdent2(bt.GetRight());

        return new BinNode<string>(left, bt.GetInfo(), right);
    }



    // =================== תשובה לתרגיל 17 פרק 10 ======================
    // שתי גירסאות: האם עץ מלא	
    // 1. 
    public static bool IsFull1(BinNode<int> bt)
    {
        if (bt.GetLeft() == null && bt.GetRight() == null)
            return true;

        if (bt.GetLeft() == null || bt.GetRight() == null)
            return false;

        if (Height(bt.GetLeft()) != Height(bt.GetRight()))
            return false;

        return IsFull1(bt.GetLeft()) && IsFull1(bt.GetRight());
    }
    // 2.
    public static bool IsFull2(BinNode<int> bt)
    {
        int h = Height(bt);  // גובה העץ
        int n = NumOfNodes(bt);  // מספר הצמתים בעץ

        return (Math.Pow(2, h + 1) - 1) == n;
    }
    // פעולת עזר: מחזירה את מספר הצמתים בעץ
    public static int NumOfNodes(BinNode<int> bt)
    {
        if (bt == null)
            return 0;

        return 1 + NumOfNodes(bt.GetLeft()) + NumOfNodes(bt.GetRight());
    }

    // =================== תשובה לתרגיל 18 פרק 10 ======================
    // שתי גירסאות: להחזרת ההורה של צומת נתון	
    // 1. גירסה רקורסיבית
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


    // =================== תשובה לתרגיל 19 פרק 10 ======================
    // בניית עץ בינרי אקראי שגובהו לכל היותר מתקבל כפרמטר	
    public static BinNode<int> BuildRandomTree(int maxLevels)
    {
        Random rndGen = new Random();

        if (maxLevels == 0)
            return new BinNode<int>(rndGen.Next(100));

        int rnd = rndGen.Next(6);
        int x = rndGen.Next(100);

        if (rnd == 0)	// עלה
            return new BinNode<int>(rndGen.Next(100));

        if (rnd == 1)	//בן שמאלי בודד
            return new BinNode<int>(BuildRandomTree(maxLevels - 1), x, null);

        if (rnd == 2) // בן ימני בודד
            return new BinNode<int>(null, x, BuildRandomTree(maxLevels - 1));

        // שני בנים
        return new BinNode<int>(BuildRandomTree(maxLevels - 1), x, BuildRandomTree(maxLevels - 1));
    }


    // =================== תשובה לתרגיל 20 פרק 10 ======================
    // בניית עץ בינרי משתי סריקות נתונות
    public static BinNode<int> BuildTree(int[] preorder, int[] inorder)
    {
        int i = 0;
        BinNode<int> bt = new BinNode<int>(preorder[0]);

        //המשתנה יצביע על מקום האיבר הראשון של הסריקה התחילית בתוך הסריקה התוכית
        while (preorder[0] != inorder[i])
            i++;

        //תת העץ השמאלי
        if (i > 0)
        {
            int[] preorderL = new int[i];
            int[] inorderL = new int[i];
            for (int j = 0; j < i; j++)
            {
                preorderL[j] = preorder[j + 1];
                inorderL[j] = inorder[j];
            }
            bt.SetLeft(BuildTree(preorderL, inorderL));
        }

        //תת העץ הימני
        if (i < inorder.Length - 1)
        {
            int[] preorderR = new int[inorder.Length - 1 - i];
            int[] inorderR = new int[inorder.Length - 1 - i];
            for (int j = i + 1; j < inorder.Length; j++)
            {
                preorderR[j - i - 1] = preorder[j];
                inorderR[j - i - 1] = inorder[j];
            }
            bt.SetRight(BuildTree(preorderR, inorderR));
        }

        return bt;
    }

    // =================== תשובה לתרגיל 21 פרק 10 ======================
    // יש 3 גירסאות לפתרון תרגיל זה
    // 1. פתרון לא רקורסיבי המשתמש בתור
    public static int Diff1(BinNode<int> bt)
    {
        int diff = 0;
        BinNode<int> t;
        Queue<BinNode<int>> q = new Queue<BinNode<int>>();

        q.Insert(bt);
        while (!q.IsEmpty())
        {
            t = q.Remove();
            if (t.GetLeft() == null && t.GetRight() != null)
                diff += t.GetRight().GetInfo();
            if (t.GetLeft() != null && t.GetRight() == null)
                diff -= t.GetLeft().GetInfo();

            if (t.GetLeft() != null)
                q.Insert(t.GetLeft());
            if (t.GetRight() != null)
                q.Insert(t.GetRight());
        }
        return diff;
    }

    // 2. פתרון רקורסיבי עם פעולה אחת
    public static int Diff2(BinNode<int> bt)
    {
        if (bt.GetLeft() == null && bt.GetRight() == null)
            return 0;

        if (bt.GetLeft() == null)
            return Diff2(bt.GetRight()) + bt.GetRight().GetInfo();

        if (bt.GetRight() == null)
            return Diff2(bt.GetLeft()) - bt.GetLeft().GetInfo();

        return Diff2(bt.GetLeft()) + Diff2(bt.GetRight());
    }

    // 3. פתרון לא רקורסיבי המשתמש בשתי פעולות עזר רקקורסיביות
    public static int Diff3(BinNode<int> bt)
    {
        return SumOfsingelRightChild(bt) - SumOfsingelLeftChild(bt);
    }
    // פעולת עזר: מחזירה את סכום הילדים השמאליים היחידים
    public static int SumOfsingelLeftChild(BinNode<int> bt)
    {
        if (bt == null)
            return 0;

        int val = 0;
        if (bt.GetLeft() != null && bt.GetRight() == null)
            val = bt.GetLeft().GetInfo();

        return val + SumOfsingelLeftChild(bt.GetLeft()) + SumOfsingelLeftChild(bt.GetRight());
    }
    // פעולת עזר: מחזירה את סכום הילדים הימניים היחידים
    public static int SumOfsingelRightChild(BinNode<int> bt)
    {
        if (bt == null)
            return 0;

        int val = 0;
        if (bt.GetLeft() == null && bt.GetRight() != null)
            val = bt.GetRight().GetInfo();

        return val + SumOfsingelRightChild(bt.GetLeft()) + SumOfsingelRightChild(bt.GetRight());
    }


    // ======================= תשובה לשאלה 22 פרק 10 =========================
    public static bool IsSimilarTrees(BinNode<int> bt1, BinNode<int> bt2)
    {
        if ((bt1.GetLeft() != null && bt2.GetLeft() == null) ||
                (bt1.GetLeft() == null && bt2.GetLeft() != null) ||
                (bt1.GetRight() != null && bt2.GetRight() == null) ||
                (bt1.GetRight() == null && bt2.GetRight() != null))
            return false;

        bool resL = true;
        bool resR = true;

        if (bt1.GetLeft() != null)
            resL = IsSimilarTrees(bt1.GetLeft(), bt2.GetLeft());

        if (!resL)
            return false;

        if (bt1.GetRight() != null)
            resR = IsSimilarTrees(bt1.GetRight(), bt2.GetRight());

        return resR;
    }

    // ========================== תשובה לשאלה 23 פרק 10 =========================
    // בניית עץ ביטוי מהקלט
    public static BinNode<char> buildExpTree()
    {
        BinNode<char> bt = null;
        char ch = Console.ReadKey().KeyChar;

        if (char.IsDigit(ch))
            bt = new BinNode<char>(ch);
        else
            if (ch == '(')
            {
                BinNode<char> btLeft = buildExpTree();
                ch = Console.ReadKey().KeyChar; //פעולה
                BinNode<char> btRight = buildExpTree();
                bt = new BinNode<char>(btLeft, ch, btRight);
                ch = Console.ReadKey().KeyChar; //חייב להיות סוגר
            }

        return bt;
    }


    // ========================== תשובה לשאלה 24 פרק 10 =========================
    // סעיף ג
    public static int MaxInBST(BinNode<int> bst)
    {
        if (bst.GetRight() == null)
            return bst.GetInfo();
        return MaxInBST(bst.GetRight());
    }


    // ========================== תשובה לשאלה 25 פרק 10 =========================
    // סעיף ג: עץ-בינרי-משופע
    public static bool IsInclined(BinNode<int> bt)
    {
        if (bt == null || (bt.GetLeft() == null && bt.GetRight() == null))
            return true;

        bool left = true;
        bool right = true;

        if (bt.GetLeft() != null)
            left = bt.GetInfo() > bt.GetLeft().GetInfo();
        if (bt.GetRight() != null)
            right = bt.GetInfo() < bt.GetRight().GetInfo();

        return left && right && IsInclined(bt.GetLeft()) && IsInclined(bt.GetRight());
    }

}

