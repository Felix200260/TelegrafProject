<template>
  <el-card style="margin: 20px; height: 100vh;" >
    <template #header>
      <div style="display: flex; align-items: center; justify-content: space-between">
        <div style="display: flex; align-items: center">
          <div style="margin-right: 10px">Статистика соединений.</div>
          <div style="margin-right: 5px">Статус:</div>
          <el-tag type="warning" style="margin-right: 10px">
            В работе
          </el-tag>
        </div>
        <div>
          <el-tooltip content="Закрыть">
            <el-button @click="closeModal" :icon="CloseBold" type="primary"></el-button>
          </el-tooltip>
        </div>
      </div>
    </template>
    <div style="
                  height: 100vh;
                  background: #f0f2f5;
                  border-radius: 4px;
                  display: flex;
                  align-items: center;
                  justify-content: center;
                  color: #909399;
                ">
      График статистики соединений
    </div>
  </el-card>
</template>

<script setup lang="ts">
import {
  CloseBold,
} from '@element-plus/icons-vue'

const emit = defineEmits(['update:isCLickLogs'])

const props = defineProps({
  isCLickLogs: Boolean,
})

const closeModal = () => {
  emit('update:isCLickLogs', false)
}
</script>

<style scoped>

</style>