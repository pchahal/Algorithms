using System;
using System.Collections.Generic;

namespace Algorithms
{
    //given doc string and chunksize return list of chunks,
    //: is paragraph break
    //      cc:abcdef:ab:c:d:
    public class BreakDocumentIntoChunks
    {
        public List<string> BreakDoc(string doc, int chunkSize)
        {
            List<string> chunks = new List<string>();

            while (doc != "")
            {
                string chunk = GetNextChunk(doc, chunkSize);
                chunks.Add(chunk);
                doc = doc.Substring(chunk.Length);
            }
            return chunks;
        }
        
        public string GetNextChunk(string doc, int chunksize)
        {
            int i = 0;
            int paragraphStart = -1;
            while (i < doc.Length && (
                       i < chunksize || paragraphStart == -1))
            {
                
                if (doc [i] == ':')
                    paragraphStart = i;
                i++;
            }
  
            string nextChunk = doc.Substring(0, paragraphStart + 1);
            return nextChunk;
        }
    }
}

