﻿using System;
using System.Diagnostics;
using System.Security.Cryptography;

namespace PracticeExercise1
{
	public class ArrayList : IList
	{
        private int[] array;
        private int length;

		public ArrayList()
		{
            array = new int[16];
            length = 0;
		}

        // TODO
        /// <summary>
        /// Returns first element in list, null if empty.
        /// </summary>
        //int? IList.First
        //{
            
        //    {
        //        //if (IsEmpty)
        //        //{
        //        //    throw null;
        //        //}
        //        //else 
        //        //{
        //        //    return array[0];
        //        //}

                

                
        //    }
        //}

        // TODO
            /// <summary>
            /// Returns last element in list, null if empty.
            /// </summary>
        public int? Last 
        { 
            get => throw new NotImplementedException(); set => throw new NotImplementedException(); 
        }

        // TODO
        /// <summary>
        /// Returns true if list is has no elements; false otherwise.
        /// </summary>
        public bool IsEmpty 
        { 
            get => Length == 0; 
        }

        /// <summary>
        /// Number of elements in list.
        /// </summary>
        public int Length 
        {
            get => length;
        }

        // TODO fix capacity bug
        /// <summary>
        /// Adds given value to end of list.
        /// </summary>
        /// <param name="value"></param>
        public void Append(int value)
        {
            array[length] = value;
            length++;
        }

        /// <summary>
        /// Checks if the list contains the given value.
        /// </summary>
        /// <param name="value"></param>
        /// <returns>true if value is in list; false otherwise</returns>
        public bool Contains(int value)
        {
            for(int i=0; i < Length; i++)
            {
                if( array[i] == value)
                {
                    return true;
                }
            }

            return false;
        }

        // TODO
        /// <summary>
        /// Find index of first element with matching value.
        /// </summary>
        /// <param name="value"></param>
        /// <returns>Index of first element with value; -1 if element is not found</returns>
        public int FirstIndexOf(int value)
        {
            throw new NotImplementedException();
        }

        // TODO
        /// <summary>
        /// Insert new value after first instance of existing value.
        /// If existingValue is not in list, then add new value to end of list.
        /// </summary>
        /// <param name="newValue"></param>
        /// <param name="existingValue"></param>
        public void InsertAfter(int newValue, int existingValue)
        {
            throw new NotImplementedException();
        }

        // TODO
        /// <summary>
        /// Insert value at given index 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="index"></param>
        public void InsertAt(int value, int index)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Add value to beginning of list
        /// </summary>
        /// <param name="value"></param>
        public void Prepend(int value)
        {
            // shift elements to right
            ShiftRight(0);

            array[0] = value;
            length++;

        }

        private void ShiftRight( int index)
        {
            for(int i = Length-1; i >= index; i--)
            {
                array[i + 1] = array[i];
            }
        }

        private void ShiftLeft(int startingIndex)
        {
            for(int i = startingIndex; i < Length; i++)
            {
                array[startingIndex - 1] = array[i];
            }
        }

        // TODO
        /// <summary>
        /// Remove first item with given value
        /// </summary>
        /// <param name="value">value of item to be removed</param>
        public void Remove(int value)
        {
            throw new NotImplementedException();
        }

        // TODO
        /// <summary>
        /// Remove item at specififed index.
        /// </summary>
        /// <param name="index"></param>
        public void RemoveAt(int index)
        {
            ShiftLeft(index);
            length--;
        }

        // TODO
        public override string ToString()
        {
            string str = "[";
            for(int i=0; i < Length-1; i++)
            {
                str += array[i] + ",";
            }
            str += array[Length - 1];
            str += "]";

            return str;
        }
        /// <summary>
        /// Return the element at the given index.
        /// </summary>
        /// <param name="index"></param>
        /// <returns>The Element at the given index</returns>

        public int Get(int index)
        {
            if( index > Length - 1 || IsEmpty || index  < 0)
            {
                throw new IndexOutOfRangeException();
            }
            int element = array[index];

            return element;
        }

        /// <summary>
        /// Remove all elements from list
        /// </summary>
        public void Clear()
        {
            length = 0;
        }

        public IList Reverse()
        {
            IList reverse = new ArrayList();

            for(int i = 0; i < Length; i++)
            {
                reverse.Prepend(array[i]);
            }

            return reverse;
        }

        private void Resize()
        {
            Array.Resize(ref array, 2 * array.Length);
        }
    }
}

