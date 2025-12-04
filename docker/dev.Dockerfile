FROM mcr.microsoft.com/dotnet/sdk:8.0 AS dev

# Cài thêm tool nếu cần
RUN apt-get update && apt-get install -y \
    git \
    curl \
    nano \
    zip unzip \
    && rm -rf /var/lib/apt/lists/*

WORKDIR /workspace
