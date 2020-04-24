using System;
using System.Collections; 
using System.Collections.Generic;

namespace Traveler.Seller.Problem
{
    class Program
    {
        public static ArrayList takingRowPosition(int[,] matrix, int positionRowMatrix, int nodos){

            ArrayList listVector = new ArrayList();
            
            for(int j = 0; j < nodos; j++){

                listVector.Add(matrix[positionRowMatrix, j]);
            }               
        
            return listVector;

        }

        public static int getMinDistance(ArrayList rowFromMatrix){

            int minDistance = 0;
            ArrayList tmp = new ArrayList();

            for(int i = 0; i < rowFromMatrix.Count; i++){
                
                if((int) rowFromMatrix[i] > 0){

                    tmp.Add(rowFromMatrix[i]);

                }else{ continue; }
            }

            tmp.Sort();
            minDistance = (int) tmp[0];

            return minDistance;

        }

        public static int getMinDistanPosition(ArrayList rowFromMatrix, int minDistance){

            int minDistancePosition = 0;

            for(int i = 0; i < rowFromMatrix.Count; i++){
                
                if((int) rowFromMatrix[i] == minDistance){

                    minDistancePosition = (int) i;
                    break;

                }else{ continue; }
            }

            return minDistancePosition;

        }

        public static ArrayList rowPositionsToZero(ArrayList rowFromMatrix, ArrayList rowPositions){

            foreach(int position in rowPositions){

                rowFromMatrix[position] = 0;

            }

            return rowFromMatrix;

        }

        public static int[,] newMatrix(ArrayList rowToReplace, int positionToReplace, int[,] matrix){

            for(int i = positionToReplace; i <= positionToReplace; i++){

                for(int j = 0; j < rowToReplace.Count; j++){

                    matrix[i,j] = (int) rowToReplace[j];

                }

            }

            return matrix;

        }

        public static ArrayList indexToCity(ArrayList routes){

            ArrayList cities = new ArrayList();

            foreach(int element in routes){
                
                switch (element)
                {
                    case 0:
                        Console.Write("A -> ");
                        break;
                    case 1:
                        Console.Write("B -> ");
                        break;
                    case 2:
                        Console.Write("C -> ");
                        break;
                    case 3:
                        Console.Write("D -> ");
                        break;
                    case 4:
                        Console.Write("E -> ");
                        break;
                    case 5:
                        Console.Write("F -> ");
                        break;
                }

            }

            Console.Write("FIN");
            Console.WriteLine();

            return cities;

        }

        public static int lastWeigth(int[,] matrixInput, int lastPosition, int totalNodes){

            int lastWeigth = 0;

            for(int i = 0; i < totalNodes; i++){

                if(matrixInput[i, lastPosition] != 0){

                    lastWeigth = matrixInput[i, lastPosition];
                    break;

                }else{ continue; }
  
            }

            return lastWeigth;

        }

        public static int totalWeigth(ArrayList arrayWeigths, int lastWeigth){

            int totalArraytWeigths = 0;

            foreach(int element in arrayWeigths){
                
                totalArraytWeigths += element;
            
            }

            return totalArraytWeigths + lastWeigth;

        }

        public static void showWeigth(ArrayList arrayWeigths, int lastWeigth){

            Console.Write("   ");
            foreach(int element in arrayWeigths){
                
                Console.Write("{0} +  ", element);
            
            }

            Console.Write("{0} = ", lastWeigth);

        }

        static void Main(string[] args)
        {
            ArrayList routes = new ArrayList();
            ArrayList weigths = new ArrayList();
            ArrayList tmpRow = new ArrayList();
            ArrayList cities = new ArrayList();

            int minDistance = 0;
            int minDistancePosition = 0;
            int totalWeigthRoute = 0;
            int lastWeigthRoute = 0;

            int nodes = 6;
            int[,] matrix = {
                {-1, 6, 4, 12, 0, 0},
                {6, -1, 8, 0, 13, 0},
                {4, 8, -1, 23, 0, 0},
                {12, 0, 23, -1, 0, 5},
                {0, 13, 0, 0, -1, 11},
                {0, 0, 0, 5, 11, -1} 
            };

            int posInitial = 0;
            routes.Add(posInitial);

            int count = 0;

            while(count != (nodes - 1)){

                tmpRow = takingRowPosition(matrix, posInitial, nodes);
                tmpRow = rowPositionsToZero(tmpRow, routes);//Pone en cero la posición porque no puede volver a visitar ese nodo.
                minDistance = getMinDistance(tmpRow);
                weigths.Add(minDistance);
                minDistancePosition = getMinDistanPosition(tmpRow, minDistance); //2
                routes.Add(minDistancePosition);// 0, 2
                matrix = newMatrix(tmpRow, posInitial, matrix);
                posInitial = (int) routes[routes.Count - 1];
                count += 1;

            }

            Console.WriteLine("Route:");
            routes.Add(routes[0]);
            cities = indexToCity(routes);

            //Console.WriteLine("\nWeigths:");
            lastWeigthRoute = lastWeigth(matrix, (int) routes[0], nodes);
            totalWeigthRoute = totalWeigth(weigths,lastWeigthRoute);
            showWeigth(weigths,lastWeigthRoute);
            Console.Write("{0}", totalWeigthRoute);
            Console.WriteLine();


            
            




        }
    }
}
