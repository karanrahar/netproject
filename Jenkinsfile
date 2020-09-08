// Powered by Infostretch 

timestamps {

node () {

	stage ('netprojectPipe - Checkout') {
 	 checkout([$class: 'GitSCM', branches: [[name: '*/master']], doGenerateSubmoduleConfigurations: false, extensions: [], submoduleCfg: [], userRemoteConfigs: [[credentialsId: '52962f7d-e1eb-4222-a561-76a6ae71d764', url: 'https://github.com/karanrahar/netproject']]]) 
	}
	stage ('netprojectPipe - Build') {
 			// Batch build step
bat """ 
dotnet build
cd FirstcoreProject
dotnet test
dotnet run 
 """ 
	}
}
}