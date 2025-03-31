using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

public class StopWatch
{
    // Các trường private
    private DateTime startTime;
    private DateTime endTime;

    // Constructor không tham số
    public StopWatch()
    {
        startTime = DateTime.Now;
    }

    // Getter cho startTime và endTime
    public DateTime StartTime
    {
        get { return startTime; }
    }

    public DateTime EndTime
    {
        get { return endTime; }
    }

    // Phương thức Start() reset startTime
    public void Start()
    {
        startTime = DateTime.Now;
    }

    // Phương thức Stop() thiết lập endTime
    public void Stop()
    {
        endTime = DateTime.Now;
    }

    // Phương thức GetElapsedTime() trả về thời gian đã trôi qua (milliseconds)
    public double GetElapsedTime()
    {
        return (endTime - startTime).TotalMilliseconds;
    }
}

class Program
{
    // Thuật toán sắp xếp chọn (Selection Sort)
    static void SelectionSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }
            // Hoán đổi phần tử nhỏ nhất với phần tử đầu tiên của dãy chưa sắp xếp
            int temp = arr[minIndex];
            arr[minIndex] = arr[i];
            arr[i] = temp;
        }
    }

    static void Main(string[] args)
    {
        // Tạo mảng 100,000 số ngẫu nhiên
        int[] numbers = new int[100000];
        Random rand = new Random();
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = rand.Next(1, 1000000); // Số ngẫu nhiên từ 1 đến 1,000,000
        }

        // Tạo đối tượng StopWatch
        StopWatch stopWatch = new StopWatch();

        // Bắt đầu đo thời gian
        stopWatch.Start();
        SelectionSort(numbers);
        stopWatch.Stop();

        // Hiển thị thời gian thực thi
        Console.WriteLine($"Thoi gian thuc thi cua Selection Sort: {stopWatch.GetElapsedTime():F2} ms");

        // Kiểm tra xem mảng đã được sắp xếp đúng chưa (tuỳ chọn)
        bool isSorted = true;
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] < numbers[i - 1])
            {
                isSorted = false;
                break;
            }
        }
        Console.WriteLine($"Mang da duoc sap xep dung: {isSorted}");
    }
}