cmake_minimum_required(VERSION 3.5)

project(opencv LANGUAGES CXX)

set(CMAKE_CXX_STANDARD 11)
set(CMAKE_CXX_STANDARD_REQUIRED ON)

include_directories(d:/library/opencv-3.4.10-cv14/include d:/library/opencv-3.4.10-cv14/include/opencv)
link_directories(d:/library/opencv-3.4.10-cv14/x64/vc14/lib)

add_executable(opencv main.cpp)
target_link_libraries(opencv opencv_world3410d)

