### Linq_List_Contrast_Baseon_Array 使用Linq筛选满足数组条件的List集合
#### For Example: 案例

**List (集合)**
``` 
    List<Size> strList = new List<Size>();      
    strList.Add(new Size { L = "225.00", W = "170.00", T = "38.00" });
    strList.Add(new Size { L = "505.00", W = "158.00", T = "162.00" });
    strList.Add(new Size { L = "480.00", W = "340.00", T = "130.00" });
    strList.Add(new Size { L = "163.00", W = "3.00", T = "406.00" });
    strList.Add(new Size { L = "54.00", W = "23.00", T = "41.00" });
```
* Scene One： 情景一  
   base contrast array is
          {"1","3","4"} or {"1","4","3"} or {"3","1","4"} or {"3","4","1"} or {"4","1","3"} or {"4","3","1"}
    after contrast,the result is {"163.00""3.00","406.00"},{"480.00","340.00","130.00"}
    
* Scene Two： 情景二
    list is 
          List<Size> strList = new List<Size>();      
          strList.Add(new Size { L = "225.00", W = "170.00", T = "38.00" });
          strList.Add(new Size { L = "505.00", W = "158.00", T = "162.00" });
          strList.Add(new Size { L = "480.00", W = "340.00", T = "130.00" });
          strList.Add(new Size { L = "163.00", W = "3.00", T = "406.00" });
          strList.Add(new Size { L = "54.00", W = "23.00", T = "41.00" });
    base contrast array is
          {"1","","4"} or  {"4","","1"} or  {"","1","4"} or  {"","4","1"} or  {"1","4",""} or  {"4","1",""}
    after contrast,the result is
    [{"163.00""3.00","406.00"},{"480.00","340.00","130.00"}]
  
* Scene There： 情景三
    list is 
          List<Size> strList = new List<Size>();      
          strList.Add(new Size { L = "225.00", W = "170.00", T = "38.00" });
          strList.Add(new Size { L = "505.00", W = "158.00", T = "162.00" });
          strList.Add(new Size { L = "480.00", W = "340.00", T = "130.00" });
          strList.Add(new Size { L = "163.00", W = "3.00", T = "406.00" });
          strList.Add(new Size { L = "54.00", W = "23.00", T = "41.00" });
    base contrast array is
          {"1","",""} or  {"","1",""} or  {"","","1"} 
    after contrast,the result is
    [{"225.00","170.00","38.00},{"505.00","158.00","162.00"},{"163.00""3.00","406.00"},{"480.00","340.00","130.00"}]

``` C#
public class Size
{
  public string L { get; set; }
  public string W { get; set; }
  public string T { get; set; }
}
```


