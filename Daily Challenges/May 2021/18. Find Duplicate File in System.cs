using System;
using System.Linq;
using System.Collections.Generic;

public partial class MaySolution {
    public IList<IList<string>> FindDuplicate(string[] paths) {
        Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

        for(int i = 0; i < paths.Length; i++){
            string[] split = paths[i].Split(new char[] { '(', ')', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string path = split[0];
            for(int file = 1; file < split.Length; file += 2){
                if (dict.ContainsKey(split[file + 1])){
                    dict[split[file + 1]].Add(path + '/' + split[file]);
                }else{
                    dict[split[file + 1]] = new List<string>(new string[] {path + '/' + split[file]});
                }
            }
        }


        List<IList<string>> res = new List<IList<string>>();
        foreach (List<string> list in dict.Values){
            if(list.Count > 1){
                res.Add(list);
            }
        }

        return res;
    }

}