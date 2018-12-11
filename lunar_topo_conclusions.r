library(dplyr)
library(ggplot2)
library(rpgm)
library(Rcpp)
lunar_topo_data <- read.csv('./lunar_topo_data.csv')
lunar_topo_data <- lunar_topo_data[, -4]
lunar_topo_data <- lunar_topo_data[, -4]
lunar_topo_data$Labels <- 0
look.for_lat <- 30.655
#look.for_long <- 30.7658

lmao <- which(isTrue(all.equal(lunar_topo_data, look.for_lat)), arr.ind=TRUE)
print(lmao)
#which(lunar_topo_data == look.for_long, arr.ind=TRUE)


