namespace Genrics
{
    class Program
    {
        static void Main(string[] args) 
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("Ankara");
            sehirler.Add("Ankara"); 
            sehirler.Add("Ankara"); 
            sehirler.Add("Ankara");
            Console.WriteLine(sehirler.Count);

            //T kullanımından dolayı burda tipi ne verirsek parametre ona dönüşüyor.
            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("İstanbul");
            sehirler2.Add("İstanbul");
            sehirler2.Add("İstanbul");
            sehirler2.Add("İstanbul");
            sehirler2.Add("İstanbul");
            sehirler2.Add("İstanbul");
            Console.WriteLine(sehirler2.Count);
        }
    }

    class MyList<T> //Generic Class
    {
        T[] _array;
        T[] _tempArray;
        public MyList()
        {
            _array = new T[0];
        }
        public void Add(T item)
        {
            //var olan array'i yedekleyip yeni arraye yazdırma işlemi
            _tempArray = _array;
            _array = new T[_array.Length +1];
            for(int i=0; i<_tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }

            _array[_array.Length - 1] = item;
        }

        private int _count;

        public int Count
        {
            get { return _array.Length; }
            
        }


    }
}