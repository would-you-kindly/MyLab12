namespace Custom.Collections.JavaList
{
    public class CustomList<T>
    {
        private CustomLink<T> first;

        public CustomList()
        {
            first = null;
        }

        public void InsertFirst(T item)
        {
            CustomLink<T> newLink = new CustomLink<T>(item);
            newLink.Next = first;
            first = newLink;
        }

        public CustomLink<T> DeleteFirst()
        {
            if (IsEmpty())
                throw new ListIsEmptyException();

            CustomLink<T> temp = first;
            first = first.Next;
            return temp;
        }

        public CustomLink<T> Find(T item) 
        {
            if (IsEmpty())
                throw new ListIsEmptyException();

            CustomLink<T> current = first; // Начиная с 'first'
            while (!current.Item.Equals(item)) // Пока совпадение не найдено
            {
                if (current.Next == null) // Если достигнут конец списка
                    throw new ItemNotFoundException<T>(item); // и совпадение не найдено
                else // Если еще остались элементы
                    current = current.Next; // Перейти к следующему элементу
            }

            return current; // Совпадение обнаружено
        }

        public CustomLink<T> Delete(T item)
        {
            if (IsEmpty())
                throw new ListIsEmptyException();

            CustomLink<T> previous = first;
            CustomLink<T> current = first;

            while (!current.Item.Equals(item))
            {
                if (current.Next == null)
                    throw new ItemNotFoundException<T>(item); // Элемент не найден
                else
                {
                    previous = current; // Перейти к следующему элементу
                    current = current.Next;
                }
            } // Совпадение найдено

            if (current == first) // Если первый элемент,
                first = first.Next; // изменить first
            else // В противном случае
                previous.Next = current.Next; // обойти его в списке

            return current;
        }

        public override string ToString()
        {
            string result = string.Empty;
            CustomLink<T> current = first;

            while (current != null)
            {
                result += current.ToString();
                current = current.Next;
            }

            return result;
        }

        public bool IsEmpty()
        {
            return first == null;
        }
    }
}
