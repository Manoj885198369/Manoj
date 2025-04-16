pipeline {
    agent any

    stages {
        stage('Checkout') {
            steps {
                git changelog: false, poll: false, url: 'https://github.com/Manoj885198369/Manoj.git'
            }
        }

        stage('Restore Dependencies') {
            steps {
                sh 'dotnet restore'
            }
        }
