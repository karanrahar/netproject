pipeline {
    agent any

    stages {
         
        stage('Restore') {
            steps {
                bat "dotnet restore"
            }
        }
        stage('Clean') {
            steps {
                bat "dotnet clean"
            }
        }
        stage('Build') {
            steps {
                bat "dotnet build"
            }
        }
        stage('Test') {
            steps {
                bat "dotnet test"
            }
        }
         stage('Run') {
            steps {
                bat "cd FirstcoreProj; dotnet run"
            }
        }
         stage('Publish') {
            steps {
                bat "dotnet publish"
            }
        }
    }
}
