using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Homework // don't edit this line!!!
{
    public class BinarySearchHomework // don't edit this line!!!
    {
        public static int TernarySearch(int[] arr, int key, int start, int end) // don't edit this line!!!
                                                                                // يمكنك تجاهل برمترات البداية والنهاية إذا لا تريد استخدام الطريقة العودية 
                                                                                // لكن لاتقوم بحذفهم أو التعديل عليهم هنا تحت اي ظرف!!!
                                                                                // من الممكن تمرير قيمة 0 لتجاهلهم
        {
            if (start <= end)
            {
                int partition_size = (end - start) / 3;
                int right_mid = start + partition_size;
                int left_mid = end - partition_size;

                if (arr[right_mid] == key)
                {
                    return right_mid;
                }

                if (arr[left_mid] == key)
                {
                    return left_mid;
                }
                if (key < arr[right_mid])
                {
                    return TernarySearch(arr, key, start, right_mid - 1);
                }
                if (key > arr[left_mid])
                {
                    return TernarySearch(arr, key, left_mid + 1, end);
                }
                else
                {
                    return TernarySearch(arr, key, right_mid + 1, left_mid - 1);
                }
            }
            return -1;
        }

        public static int BinarySearchForCalculatingRepeated
            (int[] arr, int key, bool is_first, int start, int end) // don't edit this line!!!
                                                                    // يمكنك تجاهل برمترات البداية والنهاية إذا لا تريد استخدام الطريقة العودية 
                                                                    // لكن لاتقوم بحذفهم أو التعديل عليهم هنا تحت اي ظرف!!!
                                                                    // من الممكن تمرير قيمة 0 لتجاهلهم
        {
            if (end >= start)
            {
                int mid = start + (end - start) / 2;
                if (arr[mid] == key)
                {
                    if (is_first)
                    {
                        if (mid == start || arr[mid - 1] != key)
                        {
                            return mid;
                        }
                        else
                        {
                            return BinarySearchForCalculatingRepeated(arr, key, is_first, start, mid - 1);
                        }
                    }

                    else
                    {
                        if (mid == end || arr[mid + 1] != key)
                        {
                            return mid;
                        }
                        else
                        {
                            return BinarySearchForCalculatingRepeated(arr, key, is_first, mid + 1, end);
                        }
                    }
                }
                if (arr[mid] > key)
                {
                    return BinarySearchForCalculatingRepeated(arr, key, is_first, start, mid - 1);
                }
                return BinarySearchForCalculatingRepeated(arr, key, is_first, mid + 1, end);
            }

            return -1;
        }

        public static int GetRepeatCount(int[] arr, int key) // don't edit this line!!!
        {
            int firstElement = BinarySearchForCalculatingRepeated(arr, key, true, 0, arr.Length - 1);
            int lastElement = BinarySearchForCalculatingRepeated(arr, key, false, 0, arr.Length - 1);

            return lastElement - firstElement + 1;

        }
    }
}

