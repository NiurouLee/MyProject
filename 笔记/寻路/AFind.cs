using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A*寻路学习  优先搜索可能产生路径的算法
///            如何拿到优先可能产生路径的算法呢   曼哈顿距离（只考虑横着或者竖着）
///      开启列表：所有待检测的
///      关闭列表：所有不会被检测的
///      G值：初始节点到任意节点n的代价
///      H值：从节点n到目标的启发式评估价值
///      F值  G+H
/// 
/// </summary>
public class AFind
{

   private List<Node> openList = new List<Node>();
   private HashSet<Node> closeSet = new HashSet<Node>();
   private int GridCountX; 
   private  int GridCountY;
   private Node[,] Grid;
   public Stack<Node> ResultNodes;

   public AFind( Node[,] inGrid,int inGridCountX, int inGridCounty)
   {
      Grid = inGrid;
      GridCountX = inGridCountX;
      GridCountY = inGridCounty;
   }


   public Stack<Node> FindPath(Node startNode, Node endNode)
   {
      openList.Clear();
      closeSet.Clear();
      openList.Add(startNode);
      int count = openList.Count;
      while (count > 0)
      {
         //开始找F自小的节点  此处可以使用小根堆代替  F相同对比H值
         Node currentNode = openList[0];
         for (int i = 0; i < count; i++)
         {
            Node node = openList[i];
            if (node.FCost < currentNode.FCost || node.FCost == count && node.m_hCost < currentNode.m_hCost)
            {
               currentNode = node;
            }
         }

         //把当前节点从open列表中移除 加入到close 节点
         openList.Add(currentNode);
         closeSet.Add(currentNode);
         if (currentNode == endNode)
         {
            GeneratePath(startNode, endNode);
            return  ResultNodes;
         }

         var neighborNodes = GetNeighbor(currentNode);
         for (int i = 0; i < neighborNodes.Count; i++)
         {
            var node = neighborNodes[i];
            if (!node.m_CanWalk || closeSet.Contains(node))
            {
               continue;
            }

            int gCost = currentNode.m_gCost + GetDistanceNodes(currentNode, node);

            if (gCost < node.m_gCost)
            {
               node.m_gCost = gCost;
               node.m_hCost = GetDistanceNodes(node, endNode);
               node.m_parent = currentNode;
               if (!openList.Contains(node))
               {
                  openList.Add(node);
               }
            }
         }
      }

      return null;
   }

   /// <summary>
   /// 生成路径
   /// </summary>
   /// <param name="startNode"></param>
   /// <param name="endNode"></param>
   private void GeneratePath(Node startNode, Node endNode)
   {
      Stack<Node> path = new Stack<Node>();
      Node node = endNode;
      while (node.m_parent!=startNode)
      {
         path.Push(node);
         node = node.m_parent;
      }

      ResultNodes = path;
   }



   /// <summary>
   ///  获取两个节点的距离
   /// </summary>
   /// <param name="currentNode"></param>
   /// <param name="node"></param>
   /// <returns></returns>
   private int GetDistanceNodes(Node node1, Node node2)
   {
      int deltaX = Mathf.Abs(node1.m_GridX - node2.m_GridX);
      int deltaY = Mathf.Abs(node1.m_GridY - node2.m_GridY);
      if (deltaX>deltaY)
      {
         return deltaY * 14 + 10 * (deltaX - deltaY);
      }
      else
      {
         return deltaX * 14 + 10 * (deltaY - deltaX);
      }
   }

   /// <summary>
   /// 获取当前节点的相邻节点
   /// </summary>
   /// <returns></returns>
   private List<Node> GetNeighbor(Node node)
   {
      List<Node> neighborList = new List<Node>(8);
      for (int i = -1; i <=1; i++)
      {
         for (int j =-1; j <=1; j++)
         {
            if (i==0&&j==0)
            {
               continue;
            }

            int tempX = node.m_GridX + i;
            int tempY = node.m_GridY + j;
            if (tempX<GridCountX&&tempX>0&& tempY>0&&tempY<GridCountY)
            {
               neighborList.Add(Grid[i,j]);
            }
         }
      }

      return neighborList;
   }
}

public class Node
{

   //是否可以通过
   public bool m_CanWalk;

   //节点的空间位置
   public Vector3 m_WorldPos;
   
   //节点在数组的位置
   public int m_GridX;
   public int m_GridY;
   
   //开始节点到当前节点的距离估值   G值
   public int m_gCost;
   
   //当前节点到目标节点的距离估值    H值
   public int m_hCost;

   // F 值
   public int FCost
   {
      get { return m_gCost + m_hCost; }
   }

   //父节点
   public Node m_parent;


   public Node(bool canWalk, Vector3 position, int gridX, int gridY)
   {
      m_CanWalk = canWalk;
      m_WorldPos = position;
      m_GridX = gridX;
      m_GridY = gridY;

   }
}
/*       --记录关于A*的点
 *     1.A*并不是最短路径，但他是最快的(ONlg(N)),最差情况是从起点触发将所有的格子走一遍，才找到目的地
 *       有点类似于贪心，局部最优解，每次都找最近的 也就是F值最小的开始
 *     2.如果地图很大，每次都需要从openList中选最小的点，可能会很费，如果不是为了找最快，而只是为了脱手操作
 *       那么可以考虑离线操作，提前算好一些固定点之间的路径，然后只需要算起点到固定点和终点到固定点的路径。
 *     3.或者将open队列替换成一个小根堆
 *     4.如果地图超大，可以考虑将寻路区域拆分，分区进行寻路。
 *     5.close节点使用了HashSet,会有额外的空间复杂度，可以考虑给node添加一个index，和一个静态的index，
 *       每次寻路将静态index+1，然后用过的点的index=静态index，如果==就不放入open队列
 *
 *
 * 
 */


