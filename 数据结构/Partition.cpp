#include<stdio.h>
#include<time.h>

clock_t start,stop;
int Partition(int a[],int n);


int main()
{
	int a[60000],n;
	scanf("%d",&n);
	for(int i=0;i<n;i++)
	{
		scanf("%d",&a[i]);
	}
	printf("%d\n",Partition(a,n));
}

///  将数组a的整数集合划分成两个不相关子集，使得|n1-n2|最小，且|S1-S2|最大，返回|S1-S2|的结果。
int Partition(int a[],int n)
{
    //记录开始时间
	start = clock();
    //排序
	for(int i=0; i<n/2; i++){
		for(int j = n-1 ; j>0 ; j--){
			if(a[j]<a[j-1]){
				int t = a[j];
				 a[j] = a[j-1];
				 a[j-1] = t;
			}
		}
	}
    //记录结束时间
	stop = clock();
	double dura;
	dura = (double) (stop - start) / CLK_TCK;
	printf("%.6f\n",dura*1000000);
	int s = 0,ss = 0;
    //算法
	for(int i = 0 ; i< n  ; i++){
		if(i<n/2)
			s+=a[i];
		else
			ss+= a[i];
	}
	
	int m = s - ss;
	if(m<0)
		m= -m;
	return m;
}