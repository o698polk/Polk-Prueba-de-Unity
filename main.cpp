#include <cstdlib>
#include <iostream>
#include <string>
using namespace std;
using std::cout;
using std::cin;
using std::endl;
using std::string;

int main(int argc, char *argv[])
{
	int NumeroListat=0,NumeroEvaluar=0,c=0,p=0,b=0,t=0;
	string BaseDatos,NumeroEvaluados,mx,mn,dato,dg;

			cout << "INGRESE UN NUMERO: DEFINA EL TAMAÑO DE LA LISTA"  << "\n";cin >>NumeroListat;
			cout << "INGRESE LOS NUMERO: COMO BASE PARA LA EVALUACIÓN"  << "\n";cin >>BaseDatos;
			while(BaseDatos.size()>NumeroListat){
			cout << "INGRESE LOS NUMERO: COMO BASE PARA LA EVALUACIÓN (Máximo la cantidad especificada anteriormente) "  << "\n";cin >>BaseDatos;
			}
			cout << "INGRESE UN NUMERO: CANTIDAD A EVALUAR"  << "\n";cin >>NumeroEvaluar;
			cout << "INGRESE LOS NUMERO: QUE SERÁN EVALUADOS"  << "\n";cin >>NumeroEvaluados;
			while(NumeroEvaluados.size()>NumeroEvaluar){
			cout << "INGRESE LOS NUMERO: QUE SERÁN EVALUADOS ((Máximo la cantidad especificada anteriormente)"  << "\n";cin >>NumeroEvaluados;
			}

			for(int i =0;i<NumeroEvaluados.length();i++){
			dato=NumeroEvaluados[i];
			c= atoi(dato.c_str());
			p=c+1;
			b=c-1;
			mx="X";
			mn="X";
			for(int j =0;j<BaseDatos.length();j++){
			dg=BaseDatos[j];
			t=atoi(dg.c_str());
			if(p==t){
          	mx=BaseDatos[j];
			}
			if(b==t){
			mn=BaseDatos[j];
			}
			}
			cout << mn << mx << "\n";
		    }
    
	system("pause");
	return 0;
}
