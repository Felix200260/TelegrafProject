<template>
  <h1>snjbkansbkm</h1>
</template>

<script setup lang="ts">

const emit = defineEmits(['update:isCLickPoliclinic_1'])

const props = defineProps({
  isCLickPoliclinic_1: Boolean,
})

const closeModal = () => {
  emit('update:isCLickPoliclinic_1', false)
}

</script>

<style scoped>

</style>