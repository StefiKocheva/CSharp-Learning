namespace Threeuple
{

    public class Threeuple<T>
    {
        private T firstEleemnt;
        private T secondEleemnt;
        private T thirdEleemnt;

        public T FirstElement
        {
            get { return firstEleemnt; }
            set { firstEleemnt = value; }
        }
        public T SecondEleemnt
        {
            get { return secondEleemnt; }
            set { secondEleemnt = value; }
        }

        public T ThirdElement
        {
            get { return thirdEleemnt; }
            set { thirdEleemnt = value; }
        }
    }
}
